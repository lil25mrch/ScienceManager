using System.Configuration;
using Ninject.Modules;
using ScienceManager.DAL.Entities;
using ScienceManager.DAL.Factories;
using ScienceManager.DAL.Factories.Contracts;
using ScienceManager.DAL.Providers;
using ScienceManager.DAL.Providers.Contracts;

namespace ScienceManager {
    public class ScienceManagerModule : NinjectModule
    {
        public override void Load()
        { 
            Bind<IDataConnectionFactory>().ToMethod(e => new DataConnectionFactory(ConfigurationManager.AppSettings["connectionString"]));
            Bind<IDbProvider<Employee>>().To<DbProvider<Employee>>().InSingletonScope();
            Bind<IDbProvider<Department>>().To<DbProvider<Department>>().InSingletonScope();
            Bind<Form1>().ToSelf().InSingletonScope();
            Bind<ManagerWindow>().ToSelf().InSingletonScope();
        }
    }
}