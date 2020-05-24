using ScienceManager.DAL.Context.Contracts;

namespace ScienceManager.DAL.Factories.Contracts {
    /// <summary>
    /// Фабрика подключения к базе данных
    /// </summary>
    internal interface IDataConnectionFactory {
        /// <summary>
        /// Создает подключение к базе данных
        /// </summary>
        /// <returns></returns>
        IDataConnection Create();
    }
}