using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using System;

namespace TODOList.Shared.IOC.Configurations
{
    internal class MediatRIOC
    {
        /// <summary>
        /// function for apply ioc configuration of MediatR
        /// </summary>
        /// <param name="containerBuilder"></param>
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterMediatR(AppDomain.CurrentDomain.Load("TODOList.Domain"));
        }
    }
}
