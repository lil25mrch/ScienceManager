using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using ScienceManager.DAL.Context.Contracts;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Factories.Contracts;
using ScienceManager.DAL.Providers.Contracts;
using ScienceManager.Models;

namespace ScienceManager.DAL.Providers {
    internal class EmployeeProvider : DbProvider<Employee>, IEmploeeProvider {
        private readonly IDataConnectionFactory _connectionFactory;

        public EmployeeProvider(IDataConnectionFactory connectionFactory)
            : base(connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<EmployeeModel>> GetAllWithDepartment() {
            using (IDataConnection connection = _connectionFactory.Create()) {
                return await connection.From<Employee>()
                    .Join(connection.From<Department>(), employee => employee.DepartmentId, department => department.Id, (employee, department) => new EmployeeModel {
                        Department = department.Name,
                        Address = employee.Address,
                        Birthday = employee.Birthday,
                        Details = employee.Details,
                        Name = employee.Name,
                        Patronymic = employee.Patronymic,
                        Surname = employee.Surname,
                        Id = employee.Id
                    })
                    .ToListAsync();
            }
        }
    }
}