using LinqToDB.Common;
using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    [Table("department")]
    public class Department : BaseEntity {
        public Department() {
            Name = "Default";
        }

        [Column(Name = "name", CanBeNull = false)]
        public string Name { get; set; }

        public override bool Verify() {
            if (Name.IsNullOrEmpty()) {
                return false;
            }

            return true;
        }
    }
}