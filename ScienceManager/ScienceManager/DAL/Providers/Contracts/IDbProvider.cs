using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ScienceManager.DAL.Providers.Contracts {
    /// <summary>
    /// Интерфейс провайдера к таблице базы данных
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IDbProvider<TEntity> {
        Task<List<TEntity>> GetAll();

        Task<int> Update(TEntity entity);

        Task<int> Insert(TEntity entity);
        Task<int> Delete(Expression<Func<TEntity, bool>> predicate);
    }
}