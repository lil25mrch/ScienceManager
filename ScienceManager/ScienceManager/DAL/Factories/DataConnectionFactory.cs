using ScienceManager.DAL.Context;
using ScienceManager.DAL.Context.Contracts;
using ScienceManager.DAL.Factories.Contracts;

namespace ScienceManager.DAL.Factories {
    /// <summary>
    /// Фабрика подключений к базе данных
    /// </summary>
    internal class DataConnectionFactory : IDataConnectionFactory {
        private readonly string _connectionString;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения к базе данных</param>
        public DataConnectionFactory(string connectionString) {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Создает подключение к базе данных
        /// </summary>
        /// <returns>Подключение к базе данных</returns>
        public IDataConnection Create() {
            return new ScienceManagerDataConnection(_connectionString);
        }
    }
}