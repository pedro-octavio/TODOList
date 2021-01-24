using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using System;

namespace TODOList.Shared.IOC.Configurations
{
    internal class MediatRIOC
    {
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterMediatR(AppDomain.CurrentDomain.Load("TODOList.Domain"));
        }
    }
}
