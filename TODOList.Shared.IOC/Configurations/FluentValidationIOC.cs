using Autofac;
using FluentValidation;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;
using TODOList.Domain.Validators;

namespace TODOList.Shared.IOC.Configurations
{
    internal class FluentValidationIOC
    {
        internal static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<AddTaskListCommandValidator>().As<IValidator<AddTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<AddTaskItemCommandValidator>().As<IValidator<AddTaskItemCommandRequestModel>>();

            containerBuilder.RegisterType<DeleteTaskListCommandValidator>().As<IValidator<DeleteTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<DeleteTaskItemCommandValidator>().As<IValidator<DeleteTaskItemCommandRequestModel>>();

            containerBuilder.RegisterType<GetAllTaskItemsQueryValidator>().As<IValidator<GetAllTaskItemsQueryRequestModel>>();

            containerBuilder.RegisterType<GetTaskListByIdQueryValidator>().As<IValidator<GetTaskListByIdQueryRequestModel>>();
            containerBuilder.RegisterType<GetTaskItemByIdQueryValidator>().As<IValidator<GetTaskItemByIdQueryRequestModel>>();

            containerBuilder.RegisterType<UpdateTaskListCommandValidator>().As<IValidator<UpdateTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<UpdateTaskItemCommandValidator>().As<IValidator<UpdateTaskItemCommandRequestModel>>();
        }
    }
}
