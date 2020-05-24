using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Providers.Contracts;

namespace ScienceManager {
    /// <summary>
    /// Класс добавления нового отдела
    /// </summary>
    public partial class AddDepartmentWindow : Form {
        private readonly IDbProvider<Department> _dbDepartment;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="dbDepartment"></param>
        public AddDepartmentWindow(IDbProvider<Department> dbDepartment) {
            _dbDepartment = dbDepartment;
            InitializeComponent();
        }

        /// <summary>
        /// Добавить новый отдел
        /// </summary>
        /// <returns></returns>
        private async Task AddDeparnment() {
            Department newDeparnment = new Department();
            newDeparnment.Name = newDepartmentTextBox.Text;
            await _dbDepartment.Insert(newDeparnment);
        }

        /// <summary>
        /// Кнопка добавить новый отдел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddNewDepartmentClick(object sender, EventArgs e) {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                try {
                    await AddDeparnment();
                    Close();
                } catch (Exception ex) {
                    MessageBox.Show($"При добавлении записи произошла ошибка");
                }
            }
        }

        /// <summary>
        /// Валидация названия отдела
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNameDepartmentValidate(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(newDepartmentTextBox.Text)) {
                e.Cancel = true;
                newDepartmentTextBox.Focus();
                nameNewDepartmentError.SetError(newDepartmentTextBox, "Это обязательное поле");
            } else {
                e.Cancel = false;
                nameNewDepartmentError.SetError(newDepartmentTextBox, "");
            }
        }
    }
}