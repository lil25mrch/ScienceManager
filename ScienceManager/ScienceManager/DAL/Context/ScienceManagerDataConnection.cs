using System;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.PostgreSQL;
using ScienceManager.DAL.Context.Contracts;

namespace ScienceManager.DAL.Context {
    internal class ScienceManagerDataConnection : DataConnection, IDataConnection {
        public ScienceManagerDataConnection(string connectionString)
            : base(new PostgreSQLDataProvider(), connectionString) {
            TurnTraceSwitchOn();
            WriteTraceLine = (message, displayName) => { Console.WriteLine($"{message} {displayName}"); };
        }

        public IQueryable<TSource> From<TSource>() where TSource : class {
            return GetTable<TSource>();
        }

        public async Task<int> InsertWithInt32IdentityAsync<TSource>(TSource source) where TSource : class {
            return await DataExtensions.InsertWithInt32IdentityAsync(this, source);
        }

        public async Task<int>  Update<TSource>(TSource source) where TSource : class {
            return await  DataExtensions.UpdateAsync(this, source);
        }
    }
}