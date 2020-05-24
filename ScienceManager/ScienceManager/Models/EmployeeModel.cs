using System;

namespace ScienceManager.Models {
    /// <summary>
    /// Структура данных для отображения сотрудников в dataGridView
    /// </summary>
    public class EmployeeModel {
        /// <summary>
        /// ID сотрудника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Название отдела
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Адрес сотрудника
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        public string Details { get; set; }
    }
}