using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqToDB;
using ScienceManager.DAL.Context.Contracts;
using ScienceManager.DAL.Factories.Contracts;
using ScienceManager.DAL.Providers.Contracts;

namespace ScienceManager.DAL.Providers {
    internal class DbProvider<TEntity> : IDbProvider<TEntity> where TEntity : class {
        private readonly IDataConnectionFactory _connectionFactory;

        public DbProvider(IDataConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<TEntity>> GetAll() {
            using (IDataConnection connection = _connectionFactory.Create()) {
                return await connection.From<TEntity>().ToListAsync();
            }
        }

        public async Task<int> Delete(Expression<Func<TEntity, bool>> predicate) {
            using (IDataConnection connection = _connectionFactory.Create()) { 
                var count = await connection.From<TEntity>().Where(predicate).DeleteAsync();
                return count;
            }
        }

        public async Task<int> Update(TEntity entity) {
            using (IDataConnection connection = _connectionFactory.Create()) {
                int count = await connection.Update(entity);
                return count;
            }
        }

        public async Task<int> Insert(TEntity entity) {
            using (IDataConnection connection = _connectionFactory.Create()) {
                int id = await connection.InsertWithInt32IdentityAsync(entity);
                return id;
            }
        }
    }
}