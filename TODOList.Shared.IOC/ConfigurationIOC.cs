using Autofac;
using TODOList.Shared.IOC.Configurations;

namespace TODOList.Shared.IOC
{
    internal class ConfigurationIOC
    {
        internal static void Load(ContainerBuilder containerBuilder)
        {
            MediatRIOC.Load(containerBuilder);

            AutomapperIOC.Load(containerBuilder);

            RepositoryIOC.Load(containerBuilder);
        }
    }
}
