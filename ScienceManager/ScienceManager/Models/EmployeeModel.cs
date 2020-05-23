using System;

namespace ScienceManager.Models {
    public class EmployeeModel {
        public int Id { get; set; }
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Department { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string Details { get; set; }
    }
}