using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using TODOList.Domain.Mappers;

namespace TODOList.Shared.IOC.Configurations
{
    internal class AutomapperIOC
    {
        /// <summary>
        /// function for apply ioc configuration of Automapper
        /// </summary>
        /// <param name="containerBuilder"></param>
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterAutoMapper(typeof(MappingProfile).Assembly);
        }
    }
}
