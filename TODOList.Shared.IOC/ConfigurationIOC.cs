using Autofac;
using TODOList.Shared.IOC.Configurations;

namespace TODOList.Shared.IOC
{
    internal class ConfigurationIOC
    {
        /// <summary>
        /// function for load all ioc's configuration
        /// </summary>
        /// <param name="containerBuilder"></param>
        internal static void Load(ContainerBuilder containerBuilder)
        {
            MediatRIOC.Load(containerBuilder);

            AutomapperIOC.Load(containerBuilder);

            FluentValidationIOC.Load(containerBuilder);

            RepositoryIOC.Load(containerBuilder);
        }
    }
}
