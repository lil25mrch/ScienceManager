﻿using System;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.PostgreSQL;
using ScienceManager.DAL.Context.Contracts;

namespace ScienceManager.DAL.Context {
    /// <summary>
    /// Cоединение с базой данных
    /// </summary>
    internal class ScienceManagerDataConnection : DataConnection, IDataConnection {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString"></param>
        public ScienceManagerDataConnection(string connectionString)
            : base(new PostgreSQLDataProvider(), connectionString) {
            TurnTraceSwitchOn();
            WriteTraceLine = (message, displayName) => { Console.WriteLine($"{message} {displayName}"); };
        }

        /// <summary>
        /// Запрос таблицы
        /// </summary>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>Запрашиваемая таблица</returns>
        public IQueryable<TSource> From<TSource>() where TSource : class {
            return GetTable<TSource>();
        }

        /// <summary>
        /// Добавление данных
        /// </summary>
        /// <param name="source">Экземпляр данных для добавления</param>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>ID сущности в базе</returns>
        public async Task<int> InsertWithInt32IdentityAsync<TSource>(TSource source) where TSource : class {
            return await DataExtensions.InsertWithInt32IdentityAsync(this, source);
        }

        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="source">Экземпляр данных для обновления</param>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>Количество обновленных записей</returns>
        public async Task<int> Update<TSource>(TSource source) where TSource : class {
            return await DataExtensions.UpdateAsync(this, source);
        }
    }
}