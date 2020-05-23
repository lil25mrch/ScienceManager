using System.Collections.Generic;
using System.Threading.Tasks;
using ScienceManager.DAL.Entities;
using ScienceManager.Models;

namespace ScienceManager.DAL.Providers.Contracts {
    public interface IEmploeeProvider : IDbProvider<Employee> {
        Task<List<EmployeeModel>> GetAllWithDepartment();
    }
}