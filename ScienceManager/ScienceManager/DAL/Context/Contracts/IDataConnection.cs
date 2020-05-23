using System;
using System.Linq;

namespace ScienceManager.DAL.Context.Contracts {
    internal interface IDataConnection : IDisposable {
        IQueryable<TSource> From<TSource>() where TSource : class;

        int InsertWithInt32Identity<TSource>(TSource source) where TSource : class;
        int Update<TSource>(TSource source) where TSource : class;
    }
}