using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ScienceManager.DAL.Providers.Contracts {
    /// <summary>
    /// Интерфейс провайдера к базе данных
    /// </summary>
    /// <typeparam name="TEntity">Сущность таблицы</typeparam>
    public interface IDbProvider<TEntity> {
        /// <summary>
        /// Получить список значений таблицы
        /// </summary>
        /// <returns>Список значений</returns>
        Task<List<TEntity>> GetAll();

        /// <summary>
        /// Изменить значение в таблице
        /// </summary>
        /// <param name="entity">Сущность для обновления</param>
        /// <returns>Число измененных значений</returns>
        Task<int> Update(TEntity entity);

        /// <summary>
        /// Добавить значение в таблицу
        /// </summary>
        /// <param name="entity">Сущность для добавления</param>
        /// <returns>ID сущности</returns>
        Task<int> Insert(TEntity entity);

        /// <summary>
        /// Удалить значения из таблицы
        /// </summary>
        /// <param name="predicate">Фильтр удаления записи</param>
        /// <returns>Количество удаленных значений</returns>
        Task<int> Delete(Expression<Func<TEntity, bool>> predicate);
    }
}