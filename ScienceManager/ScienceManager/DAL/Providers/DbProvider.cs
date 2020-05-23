using System.Collections.Generic;
using System.Linq;
using ScienceManager.DAL.Context.Contracts;
using ScienceManager.DAL.Factories.Contracts;
using ScienceManager.DAL.Providers.Contracts;

namespace ScienceManager.DAL.Providers {
    internal class DbProvider<TEntity> : IDbProvider<TEntity> where TEntity : class {
        private readonly IDataConnectionFactory _connectionFactory;

        public DbProvider(IDataConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public List<TEntity> GetAll() {
            using (IDataConnection connection = _connectionFactory.Create()) {
                return connection.From<TEntity>().ToList();
            }
        }

        public int Update(TEntity entity) {
            using (IDataConnection connection = _connectionFactory.Create()) {
                int count = connection.Update(entity);
                return count;
            }
        }

        public int Insert(TEntity entity) {
            using (IDataConnection connection = _connectionFactory.Create()) {
                int id = connection.InsertWithInt32Identity(entity);
                return id;
            }
        }
    }
}