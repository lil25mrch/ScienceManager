using System.Collections.Generic;
using System.Threading.Tasks;
using ScienceManager.DAL.Entities;
using ScienceManager.Models;

namespace ScienceManager.DAL.Providers.Contracts {
    /// <summary>
    /// Интерфейс провайдера к таблице Сотрудники
    /// </summary>
    public interface IEmploeeProvider : IDbProvider<Employee> {
        /// <summary>
        /// Получить список моделей сотрудников
        /// </summary>
        /// <returns>Список моделей сотрудников</returns>
        Task<List<EmployeeModel>> GetAllWithDepartment();
    }
}