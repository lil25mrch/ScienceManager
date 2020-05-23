using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    [Table("department")]
    public class Department {
        [Column("id")]
        [Identity]
        [PrimaryKey]

        public int Id { get; set; }

        [Column(Name = "name", CanBeNull = false)]
        public string Name { get; set; }
    }
}