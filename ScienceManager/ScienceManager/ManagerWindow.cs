using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Providers.Contracts;
using ScienceManager.Models;

namespace ScienceManager {
    public partial class ManagerWindow : Form {
        private BindingSource _bindingSource;
        private readonly IDbProvider<Department> _dbDepartment;
        private readonly IEmploeeProvider _dbEmployee;
        private readonly IModelMapper _modelMapper;
        private Dictionary<string, int> departmentDictionary;
        private Dictionary<int, EmployeeModel> employeeDictionary;
        private int currentRowIndex;

        public ManagerWindow(IEmploeeProvider dbEmployee, IDbProvider<Department> dbDepartment, IModelMapper modelMapper) {
            _dbEmployee = dbEmployee;
            _dbDepartment = dbDepartment;
            _modelMapper = modelMapper;
            InitializeComponent();
            InitialiseGrid();
        }

        private async void InitialiseGrid() {
            var listEmployee = await _dbEmployee.GetAllWithDepartment();
            employeeDictionary = listEmployee.ToDictionary( e => e.Id);
            _bindingSource = new BindingSource {DataSource = employeeDictionary.Values};
            EmployeeDataGrid.DataSource = _bindingSource;
            var listDepartment = await _dbDepartment.GetAll();
            departmentDictionary = listDepartment.ToDictionary(e => e.Name, e => e.Id);
            departmentBox.Items.Clear();
            foreach (string departmentKey in departmentDictionary.Keys) {
                departmentBox.Items.Add(departmentKey);
            }
        }

        public EmployeeModel GetDataFromForm(Employee employee) {
            employee.Surname = surnameTextBox.Text;
            employee.Name = nameTextBox.Text;
            employee.Patronymic = patronymicTextBox.Text;
            string departmentName = departmentBox.SelectedItem.ToString();
            employee.DepartmentId = departmentDictionary[departmentName];
            employee.Birthday = birthdayBox.Value;
            employee.Address = addressTextBox.Text;
            employee.Details = detailsTextBox.Text;

            EmployeeModel employeeModel = _modelMapper.Map<EmployeeModel>(employee);
            employeeModel.Department = departmentName;
            return employeeModel;
        }

        private async Task InsertEmployee() {
            Employee newEmployee = new Employee();
            EmployeeModel employeeModel = GetDataFromForm(newEmployee);
            int id = await _dbEmployee.Insert(newEmployee);
            newEmployee.Id = id;

            employeeDictionary.Add(id, employeeModel);
            _bindingSource.Add(employeeModel);
        }

        private async Task UpdateEmployee() {
            int employeeId = Int32.Parse(idLabel.Text);
            if (employeeDictionary.ContainsKey(employeeId)) {
                await _dbEmployee.Delete(employee => employee.Id == employeeId);

                employeeDictionary.Remove(employeeId);
                _bindingSource.RemoveAt(currentRowIndex);
            }
        }

        private async Task DeleteEmployee() {
            int employeeId = Int32.Parse(idLabel.Text);
            if (employeeDictionary.ContainsKey(employeeId)) {
                Employee employee = new Employee();
                employee.Id = employeeId;
                EmployeeModel newModel = GetDataFromForm(employee);

                await _dbEmployee.Insert(employee);

                EmployeeModel employeeModel = newModel;
                employeeDictionary[employeeId] = employeeModel;
                _bindingSource[currentRowIndex] = employeeModel;
                _bindingSource.ResetItem(currentRowIndex);
            }
        }

        private async void AddButtonClick(object sender, EventArgs e) {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                try {
                    await InsertEmployee();
                } catch (Exception ex) {
                    MessageBox.Show($"При добавлении записи произошла ошибка.");
                }
            }
        }

        private async void DeleteButtonClick(object sender, EventArgs e) {
            try {
                await DeleteEmployee();
            } catch (Exception ex) {
                MessageBox.Show($"При удалении записи произошла ошибка.");
            }
        }

        private async void UpdateButtonClick(object sender, EventArgs e) {
            try {
                await UpdateEmployee();
            } catch (Exception ex) {
                MessageBox.Show($"При изменении записи произошла ошибка.");
            }
        }

        private async void RefreshButtonClick(object sender, EventArgs e) {
            try {
                InitialiseGrid();
            } catch (Exception ex) {
                MessageBox.Show($"При изменении записи произошла ошибка.");
            }
        }

        private void DataGridCellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            currentRowIndex = e.RowIndex;
            DataGridViewRow row = EmployeeDataGrid.Rows[currentRowIndex];
            int id = (int) row.Cells[0].Value;
            EmployeeModel employee = employeeDictionary[id];
            idLabel.Text = employee.Id.ToString();
            surnameTextBox.Text = employee.Surname;
            nameTextBox.Text = employee.Name;
            patronymicTextBox.Text = employee.Patronymic;
            birthdayBox.Value = employee.Birthday;
            addressTextBox.Text = employee.Address;
            detailsTextBox.Text = employee.Details;
            departmentBox.SelectedItem = employee.Department;
        }

        //Add validations      
        private void SurnameValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => string.IsNullOrWhiteSpace(control.Text), surnameTextBox, e, "Это обязательное поле");
        }

        private void NameValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => string.IsNullOrWhiteSpace(nameTextBox.Text), nameTextBox, e, "Это обязательное поле");
        }

        private void DepatmentValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => departmentBox.SelectedIndex == -1, departmentBox, e, "Выберите отдел");
        }

        private void BirthdayValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => birthdayBox.Value >= DateTime.Now, departmentBox, e, "Дата рождения не может быть больше текущей");
        }

        private void ControlValidate(Func<Control, bool> func,
                                     Control control,
                                     CancelEventArgs e,
                                     string errorMessage) {
            if (func(control)) {
                e.Cancel = true;
                control.Focus();
                valueError.SetError(control, errorMessage);
            } else {
                e.Cancel = false;
                valueError.SetError(control, "");
            }
        }
    }
}