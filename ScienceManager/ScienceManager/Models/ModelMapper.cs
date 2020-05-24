using AutoMapper;
using ScienceManager.DAL.Entities;

namespace ScienceManager.Models {
    /// <summary>
    /// Интерфейс маппера моделей
    /// </summary>
    public interface IModelMapper {
        /// <summary>
        /// Маппинг одной модели в другую
        /// </summary>
        /// <param name="source">Входная модель</param>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <returns>Результирующая модель</returns>
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
        /// Маппинг одной модели в другую
        /// </summary>
        /// <param name="source">Входная модель</param>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <returns>Результирующая модель</returns>
        public T Map<T>(object source) {
            return _modelMapper.Map<T>(source);
        }
    }
}