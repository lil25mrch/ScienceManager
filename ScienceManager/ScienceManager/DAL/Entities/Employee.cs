using System;
using LinqToDB.Common;
using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    [Table(Name = "employee")]
    public class Employee : BaseEntity {
        public Employee() {
            Surname = "Default";
            Name = "Default";
            Patronymic = "Default";
            Birthday = DateTime.Now;
        }

        [Column("surname", CanBeNull = false)]
        public string Surname { get; set; }

        [Column("name", CanBeNull = false)]
        public string Name { get; set; }

        [Column("patronymic", CanBeNull = false)]
        public string Patronymic { get; set; }

        [Column("department", CanBeNull = false)]
        public int? Department { get; set; }

        [Column("birthday", CanBeNull = false)]
        public DateTime Birthday { get; set; }

        [Column(Name = "address", CanBeNull = false)]
        public string Address { get; set; }

        [Column(Name = "details", CanBeNull = false)]
        public string Details { get; set; }

        public override bool Verify() {
            if (Surname.IsNullOrEmpty() || Name.IsNullOrEmpty()) {
                return false;
            }

            if (Birthday >= DateTime.Now) {
                return false;
            }
            if (Department < 1) {
                return false;
            }


            return true;
        }
    }
}