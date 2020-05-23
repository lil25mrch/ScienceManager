using System;
using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    [Table(Name = "employee")]
    public class Employee {
        [Column("id")]
        [Identity]
        [PrimaryKey]

        public int Id { get; set; }

        [Column("surname", CanBeNull = false)]
        public string Surname { get; set; }

        [Column("name", CanBeNull = false)]
        public string Name { get; set; }

        [Column("patronymic", CanBeNull = false)]
        public string Patronymic { get; set; }

        [Column("department", CanBeNull = false)]
        public int? DepartmentId { get; set; }

        [Column("birthday", CanBeNull = false)]
        public DateTime Birthday { get; set; }

        [Column(Name = "address", CanBeNull = false)]
        public string Address { get; set; }

        [Column(Name = "details", CanBeNull = false)]
        public string Details { get; set; }
    }
}