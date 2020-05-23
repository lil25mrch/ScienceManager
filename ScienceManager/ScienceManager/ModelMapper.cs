﻿using AutoMapper;
using ScienceManager.DAL.Entities;
using ScienceManager.Models;

namespace ScienceManager {
    public interface IModelMapper {
        T Map<T>(object source);
    }

    public class ModelMapper : IModelMapper {
        private readonly IMapper modelMapper;

        public ModelMapper() {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeModel>();
                cfg.CreateMap<EmployeeModel, Employee>();
            });

            modelMapper = configuration.CreateMapper();
        }

        public T Map<T>(object source) {
            return modelMapper.Map<T>(source);
        }
    }
}