using System;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceManager.DAL.Context.Contracts {
    /// <summary>
    /// Интерфейс соединения с базой данных
    /// </summary>
    internal interface IDataConnection : IDisposable {
        IQueryable<TSource> From<TSource>() where TSource : class;

        Task<int> InsertWithInt32IdentityAsync<TSource>(TSource source) where TSource : class;
        Task<int> Update<TSource>(TSource source) where TSource : class;
    }
}