using System;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceManager.DAL.Context.Contracts {
    /// <summary>
    /// Cоединение с базой данных
    /// </summary>
    internal interface IDataConnection : IDisposable {
        /// <summary>
        /// Запрос таблицы
        /// </summary>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>Запрашиваемая таблица</returns>
        IQueryable<TSource> From<TSource>() where TSource : class;

        /// <summary>
        /// Добавление данных
        /// </summary>
        /// <param name="source">Экземпляр данных для добавления</param>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>ID сущности в базе</returns>
        Task<int> InsertWithInt32IdentityAsync<TSource>(TSource source) where TSource : class;

        /// <summary>
        /// Изменение данных
        /// </summary>
        /// <param name="source">Экземпляр данных для обновления</param>
        /// <typeparam name="TSource">Сущность таблицы</typeparam>
        /// <returns>Количество обновленных записей</returns>
        Task<int> Update<TSource>(TSource source) where TSource : class;
    }
}