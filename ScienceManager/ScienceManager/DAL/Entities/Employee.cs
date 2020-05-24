using System;
using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    /// <summary>
    /// Структура данных Сотрудники
    /// </summary>
    [Table(Name = "employee")]
    public class Employee {
        /// <summary>
        /// ID сотрудника
        /// </summary>
        [Column("id")]
        [Identity]
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        [Column("surname", CanBeNull = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [Column("name", CanBeNull = false)]
        public string Name { get; set; }

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        [Column("patronymic", CanBeNull = false)]
        public string Patronymic { get; set; }

        /// <summary>
        /// ID отдела
        /// </summary>
        [Column("department", CanBeNull = false)]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        [Column("birthday", CanBeNull = false)]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Адрес проживания сотрудника
        /// </summary>
        [Column(Name = "address", CanBeNull = false)]
        public string Address { get; set; }

        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        [Column(Name = "details", CanBeNull = false)]
        public string Details { get; set; }
    }
}