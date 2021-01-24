using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using TODOList.Domain.Mappers;

namespace TODOList.Shared.IOC.Configurations
{
    internal class AutomapperIOC
    {
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterAutoMapper(typeof(MappingProfile).Assembly);
        }
    }
}
