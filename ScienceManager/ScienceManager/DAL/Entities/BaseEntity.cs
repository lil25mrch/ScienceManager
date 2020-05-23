using LinqToDB.Mapping;

namespace ScienceManager.DAL.Entities {
    public abstract class BaseEntity {
        [Column("id")]
        [Identity]
        [PrimaryKey]

        public int Id { get; set; }

        public abstract bool Verify();
    }
}