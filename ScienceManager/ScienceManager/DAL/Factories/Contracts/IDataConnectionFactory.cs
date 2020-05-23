using ScienceManager.DAL.Context.Contracts;

namespace ScienceManager.DAL.Factories.Contracts {
    /// <summary>
    /// Фабрика подключения к данным
    /// </summary>
    internal interface IDataConnectionFactory {
        /// <summary>
        /// Создает подключение к данным
        /// </summary>
        /// <returns></returns>
        IDataConnection Create();
    }
}