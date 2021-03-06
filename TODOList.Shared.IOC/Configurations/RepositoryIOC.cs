﻿using Autofac;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Services.Repositories;

namespace TODOList.Shared.IOC.Configurations
{
    internal class RepositoryIOC
    {
        /// <summary>
        /// function for apply ioc configuration of repositories
        /// </summary>
        /// <param name="containerBuilder"></param>
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TaskListRepository>().As<ITaskListRepository>();
            containerBuilder.RegisterType<TaskItemRepository>().As<ITaskItemRepository>();
        }
    }
}
