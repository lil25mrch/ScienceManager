using ScienceManager.DAL.Context;
using ScienceManager.DAL.Context.Contracts;
using ScienceManager.DAL.Factories.Contracts;

namespace ScienceManager.DAL.Factories {
    /// <summary>
    /// Фабрика подключений к данным
    /// </summary>
    internal class DataConnectionFactory : IDataConnectionFactory {
        private readonly string _connectionString;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="connectionString">конфиг</param>
        public DataConnectionFactory(string connectionString) {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Создает подключение к данным
        /// </summary>
        /// <returns>подключение к данным</returns>
        public IDataConnection Create() {
            return new ScienceManagerDataConnection(_connectionString);
        }
    }
}