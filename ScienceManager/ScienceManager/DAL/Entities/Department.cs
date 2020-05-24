using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    /// <summary>
    /// Структура данных Отделы
    /// </summary>
    [Table("department")]
    public class Department {
        /// <summary>
        /// ID отдела
        /// </summary>
        [Column("id")]
        [Identity]
        [PrimaryKey]
        public int Id { get; set; }

        /// <summary>
        /// Название отдела
        /// </summary>
        [Column(Name = "name", CanBeNull = false)]
        public string Name { get; set; }
    }
}