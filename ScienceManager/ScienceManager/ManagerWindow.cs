using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Providers.Contracts;

namespace ScienceManager {
    public partial class ManagerWindow : Form {
        private readonly IDbProvider<Department> _dbDepartment;
        private readonly IDbProvider<Employee> _dbEmployee;
        private readonly Dictionary<int, Employee> employeeDictionary;
        

        public ManagerWindow(IDbProvider<Employee> dbEmployee, IDbProvider<Department> dbDepartment) {
            _dbEmployee = dbEmployee;
            _dbDepartment = dbDepartment;
            InitializeComponent();
            employeeDictionary = _dbEmployee.GetAll().ToDictionary(e => e.Id);
            foreach (Employee s in employeeDictionary.Values) {
                dataGridView1.Rows.Add(s.Surname, s.Name, s.Patronymic, s.Department, s.Birthday,
                                       s.Address, s.Details, s.Id);
            }

            List<Department> departmentList = _dbDepartment.GetAll();
            foreach (var d in departmentList) {
                comboBox1.Items.Add(d.Name);
            }
        }

        public void AddCommand() {
            Employee newEmployee = new Employee();
            newEmployee.Surname = textBox1.Text;
            newEmployee.Name = textBox2.Text;
            newEmployee.Patronymic = textBox3.Text;
            newEmployee.Department = comboBox1.SelectedIndex + 1;
            newEmployee.Birthday = dateTimePicker1.Value;
            newEmployee.Address = richTextBox3.Text;
            newEmployee.Details = richTextBox1.Text;
            _dbEmployee.Insert(newEmployee);
            dataGridView1.Rows.Add(newEmployee.Surname, newEmployee.Name, newEmployee.Patronymic, newEmployee.Department, newEmployee.Birthday,
                                   newEmployee.Address, newEmployee.Details, newEmployee.Id);
        }

        public void UpdateCommang() {
            int key = Int32.Parse(label9.Text);
            if (employeeDictionary.ContainsKey(key)) {
                Employee employee = employeeDictionary[key];
                employee.Surname = textBox1.Text;
                employee.Name = textBox2.Text;
                employee.Patronymic = textBox3.Text;
                employee.Department = comboBox1.SelectedIndex + 1;
                employee.Birthday = dateTimePicker1.Value;
                employee.Address = richTextBox3.Text;
                employee.Details = richTextBox1.Text;
                _dbEmployee.Update(employee);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            AddCommand();
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e) {
            UpdateCommang();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = (int) row.Cells[7].Value;
            Employee employee = employeeDictionary[id];
            label9.Text =  employee.Id.ToString();
            textBox1.Text = employee.Surname;
            textBox2.Text = employee.Name;
            textBox3.Text = employee.Patronymic;
            comboBox1.Text = employee.Department.ToString();
            dateTimePicker1.Value = employee.Birthday;
            richTextBox3.Text = employee.Address;
            richTextBox1.Text = employee.Details;
        }
    }
}