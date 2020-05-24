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
    /// <summary>
    /// Класс для работы с базой данных
    /// </summary>
    public partial class WorkWithDataBaseWindow : Form {
        private readonly AddDepartmentWindow _addDepartmentWindow;
        private readonly IDbProvider<Department> _dbDepartment;
        private readonly IEmploeeProvider _dbEmployee;
        private readonly IModelMapper _modelMapper;
        private BindingSource _bindingSource;
        private int _currentRowIndex;
        private Dictionary<string, int> _departmentDictionary;
        private Dictionary<int, EmployeeModel> _employeeDictionary;
        private List<Department> _listDepartment;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="dbEmployee"></param>
        /// <param name="dbDepartment"></param>
        /// <param name="modelMapper"></param>
        public WorkWithDataBaseWindow(IEmploeeProvider dbEmployee,
                                      IDbProvider<Department> dbDepartment,
                                      IModelMapper modelMapper,
                                      AddDepartmentWindow addDepartmentWindow) {
            _dbEmployee = dbEmployee;
            _dbDepartment = dbDepartment;
            _modelMapper = modelMapper;
            _addDepartmentWindow = addDepartmentWindow;
            InitializeComponent(); 
            InitialiseGrid();
        }

        /// <summary>
        /// Инициализация dataGridView
        /// </summary>
        private async Task InitialiseGrid() {
            var listEmployee = await _dbEmployee.GetAllWithDepartment();
            _employeeDictionary = listEmployee.ToDictionary(e => e.Id);
            _bindingSource = new BindingSource {DataSource = _employeeDictionary.Values};
            EmployeeDataGrid.DataSource = _bindingSource;
            _listDepartment = await _dbDepartment.GetAll();
            if (_listDepartment.Count < 1 || _listDepartment == null) {
                _addDepartmentWindow.ShowDialog();
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                DeleteButton.Enabled = false;
                _listDepartment = await _dbDepartment.GetAll();
                if (_listDepartment.Count > 0) {
                    AddButton.Enabled = true;
                    UpdateButton.Enabled = true;
                    DeleteButton.Enabled = true;
                }
            }
            _departmentDictionary = _listDepartment.ToDictionary(e => e.Name, e => e.Id);
            departmentBox.Items.Clear();
            foreach (string departmentKey in _departmentDictionary.Keys) {
                departmentBox.Items.Add(departmentKey);
            }
        }

        /// <summary>
        /// Получить данные из формы
        /// </summary>
        /// <returns>Модель сотрудника</returns>
        public EmployeeModel GetDataFromForm() {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.Surname = surnameTextBox.Text;
            employeeModel.Name = nameTextBox.Text;
            employeeModel.Patronymic = patronymicTextBox.Text;
            employeeModel.Department = departmentBox.SelectedItem.ToString();
            employeeModel.Birthday = birthdayBox.Value;
            employeeModel.Address = addressTextBox.Text;
            employeeModel.Details = detailsTextBox.Text;
            return employeeModel;
        }

        /// <summary>
        /// Добавить нового сотрудника
        /// </summary>
        /// <returns></returns>
        private async Task InsertEmployee() {
            EmployeeModel employeeModel = GetDataFromForm();
            Employee newEmployee = _modelMapper.Map<Employee>(employeeModel);
            string departmentName = employeeModel.Department;
            newEmployee.DepartmentId = _departmentDictionary[departmentName];

            int id = await _dbEmployee.Insert(newEmployee);
            newEmployee.Id = id;

            _employeeDictionary.Add(id, employeeModel);
            _bindingSource.Add(employeeModel);
        }

        /// <summary>
        /// Удалить данные о сотруднике
        /// </summary>
        /// <returns></returns>
        private async Task DeleteEmployee() {
            int employeeId = Int32.Parse(idLabel.Text);
            if (_employeeDictionary.ContainsKey(employeeId)) {
                await _dbEmployee.Delete(employee => employee.Id == employeeId);

                _employeeDictionary.Remove(employeeId);
                _bindingSource.RemoveAt(_currentRowIndex);
            }
        }

        /// <summary>
        /// Изменить данные сотрудника
        /// </summary>
        /// <returns></returns>
        private async Task UpdateEmployee() {
            int employeeId = Int32.Parse(idLabel.Text);
            if (_employeeDictionary.ContainsKey(employeeId)) {
                EmployeeModel employeeModel = GetDataFromForm();
                Employee newEmployee = _modelMapper.Map<Employee>(employeeModel);
                string departmentName = employeeModel.Department;

                newEmployee.Id = employeeId;
                newEmployee.DepartmentId = _departmentDictionary[departmentName];

                await _dbEmployee.Update(newEmployee);

                _employeeDictionary[employeeId] = employeeModel;
                _bindingSource[_currentRowIndex] = employeeModel;
                _bindingSource.ResetItem(_currentRowIndex);
            }
        }

        /// <summary>
        /// Кнопка добавить нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddButtonClick(object sender, EventArgs e) {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                try {
                    await InsertEmployee();
                    await InitialiseGrid();
                } catch (Exception ex) {
                    MessageBox.Show($"При добавлении записи произошла ошибка.");
                }
            }
        }

        /// <summary>
        /// Кнопка удалить данные о сотруднике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DeleteButtonClick(object sender, EventArgs e) {
            try {
                await DeleteEmployee();
                await InitialiseGrid();
            } catch (Exception ex) {
                MessageBox.Show($"При удалении записи произошла ошибка.");
            }
        }

        /// <summary>
        /// Кнопка изменить данные о сотруднике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateButtonClick(object sender, EventArgs e) {
            try {
                await UpdateEmployee();
                await InitialiseGrid();
            } catch (Exception ex) {
                MessageBox.Show($"При изменении записи произошла ошибка.");
            }
        }

        /// <summary>
        /// Кнопка обновить данные DaraGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RefreshButtonClick(object sender, EventArgs e) {
            try {
                await InitialiseGrid();
            } catch (Exception ex) {
                MessageBox.Show($"При изменении записи произошла ошибка.");
            }
        }

        /// <summary>
        /// Кнопка добавить новый отдел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddNewDepartmentButtonClick(object sender, EventArgs e) {
            try {
                _addDepartmentWindow.ShowDialog();

                await InitialiseGrid();
            } catch (Exception ex) {
                MessageBox.Show($"При изменении записи произошла ошибка.");
            }
        }

        /// <summary>
        /// Заполнить форму из DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridCellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            _currentRowIndex = e.RowIndex;
            DataGridViewRow row = EmployeeDataGrid.Rows[_currentRowIndex];
            int id = (int) row.Cells[0].Value;
            EmployeeModel employee = _employeeDictionary[id];
            idLabel.Text = employee.Id.ToString();
            surnameTextBox.Text = employee.Surname;
            nameTextBox.Text = employee.Name;
            patronymicTextBox.Text = employee.Patronymic;
            birthdayBox.Value = employee.Birthday;
            addressTextBox.Text = employee.Address;
            detailsTextBox.Text = employee.Details;
            departmentBox.SelectedItem = employee.Department;
        }

        /// <summary>
        /// Валидация фамилии сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurnameValidate(object sender, CancelEventArgs e) {
            ControlValidate(surnameTextBox => string.IsNullOrWhiteSpace(surnameTextBox.Text), surnameTextBox, e, "Это обязательное поле");
            ControlValidate(surnameTextBox => surnameTextBox.Text.Length > 20, surnameTextBox, e, "Слишком длинное значение");
        }

        /// <summary>
        /// Валидация имени сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameValidate(object sender, CancelEventArgs e) {
            ControlValidate(nameTextBox => string.IsNullOrWhiteSpace(nameTextBox.Text), nameTextBox, e, "Это обязательное поле");
            ControlValidate(nameTextBox => nameTextBox.Text.Length > 20, nameTextBox, e, "Слишком длинное значение");
        }

        /// <summary>
        /// Валидация отчества сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatronymicValidate(object sender, CancelEventArgs e) {
            ControlValidate(patronymicTextBox => patronymicTextBox.Text.Length > 20, patronymicTextBox, e, "Слишком длинное значение");
        }

        /// <summary>
        /// Валидация отдела
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepatmentValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => departmentBox.SelectedIndex == -1, departmentBox, e, "Выберите отдел");
        }

        /// <summary>
        /// Валидация даты рождения сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => birthdayBox.Value >= DateTime.Now, birthdayBox, e, "Дата рождения не может быть больше текущей");
        }

        /// <summary>
        /// Валидация адреса сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => addressTextBox.TextLength > 100, addressTextBox, e, "Длина адреса не может быть больше 100 знаков");
        }

        /// <summary>
        /// Валидация информации о сотруднике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsValidate(object sender, CancelEventArgs e) {
            ControlValidate(control => detailsTextBox.TextLength > 100, detailsTextBox, e, "Длина информации о себе не может быть больше 150 знаков");
        }

        /// <summary>
        /// Валидация контрола
        /// </summary>
        /// <param name="func">Предикат необходимости выведения ошибки</param>
        /// <param name="control">Название контрола</param>
        /// <param name="e"></param>
        /// <param name="errorMessage">Тест ошибки</param>
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