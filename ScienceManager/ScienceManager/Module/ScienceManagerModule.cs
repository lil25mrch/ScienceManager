﻿using System.Configuration;
using Ninject.Modules;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Factories;
using ScienceManager.DAL.Factories.Contracts;
using ScienceManager.DAL.Providers;
using ScienceManager.DAL.Providers.Contracts;
using ScienceManager.Models;

namespace ScienceManager.Module {
    /// <summary>
    /// Модуль зависимостей
    /// </summary>
    public class ScienceManagerModule : NinjectModule {
        /// <summary>
        /// Загрузить зависимости
        /// </summary>
        public override void Load() {
            Bind<IDataConnectionFactory>().ToMethod(e => new DataConnectionFactory(ConfigurationManager.AppSettings["connectionString"]));
            Bind<IEmploeeProvider>().To<EmployeeProvider>().InSingletonScope();
            Bind<IModelMapper>().To<ModelMapper>().InSingletonScope();
            Bind<IDbProvider<Department>>().To<DbProvider<Department>>().InSingletonScope();
            Bind<WorkWithDataBaseWindow>().ToSelf().InSingletonScope();
            Bind<AddDepartmentWindow>().ToSelf().InSingletonScope();
        }
    }
}