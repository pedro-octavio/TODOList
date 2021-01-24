using Autofac;

namespace TODOList.Shared.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            ConfigurationIOC.Load(containerBuilder);
        }
    }
}
