using AutoMapper;
using ScienceManager.DAL.Entities;

namespace ScienceManager.Models {
    /// <summary>
    /// Интерфейс маппера моделей
    /// </summary>
    public interface IModelMapper {
        T Map<T>(object source);
    }

    /// <summary>
    /// Маппер моделей
    /// </summary>
    public class ModelMapper : IModelMapper {
        private readonly IMapper _modelMapper;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public ModelMapper() {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeModel>();
                cfg.CreateMap<EmployeeModel, Employee>();
            });

            _modelMapper = configuration.CreateMapper();
        }

        /// <summary>
        /// Преобразование сущности в модель
        /// </summary>
        /// <param name="source">Объект маппинга</param>
        /// <typeparam name="T">Сущность данных</typeparam>
        /// <returns>Преобразованная модель</returns>
        public T Map<T>(object source) {
            return _modelMapper.Map<T>(source);
        }
    }
}