using System;
using System.Linq;
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

        public int InsertWithInt32Identity<TSource>(TSource source) where TSource : class {
            return DataExtensions.InsertWithInt32Identity(this, source);
        }

        public int Update<TSource>(TSource source) where TSource : class {
            return DataExtensions.Update(this, source);
        }
    }
}