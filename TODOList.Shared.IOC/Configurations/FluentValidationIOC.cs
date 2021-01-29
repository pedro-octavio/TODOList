using Autofac;
using FluentValidation;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;
using TODOList.Domain.Validators;

namespace TODOList.Shared.IOC.Configurations
{
    internal class FluentValidationIOC
    {
        /// <summary>
        /// function for apply ioc configuration of FluentValidation
        /// </summary>
        /// <param name="containerBuilder"></param>
        internal static void Load(ContainerBuilder containerBuilder)
        {
            #region Get by Id
            containerBuilder.RegisterType<GetTaskListByIdQueryValidator>().As<IValidator<GetTaskListByIdQueryRequestModel>>();
            containerBuilder.RegisterType<GetTaskItemByIdQueryValidator>().As<IValidator<GetTaskItemByIdQueryRequestModel>>();
            #endregion

            #region Get
            containerBuilder.RegisterType<GetAllTaskItemsQueryValidator>().As<IValidator<GetAllTaskItemsQueryRequestModel>>();
            #endregion

            #region Add
            containerBuilder.RegisterType<AddTaskListCommandValidator>().As<IValidator<AddTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<AddTaskItemCommandValidator>().As<IValidator<AddTaskItemCommandRequestModel>>();
            #endregion

            #region Delete
            containerBuilder.RegisterType<DeleteTaskListCommandValidator>().As<IValidator<DeleteTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<DeleteTaskItemCommandValidator>().As<IValidator<DeleteTaskItemCommandRequestModel>>();
            #endregion

            #region Update
            containerBuilder.RegisterType<UpdateTaskListCommandValidator>().As<IValidator<UpdateTaskListCommandRequestModel>>();
            containerBuilder.RegisterType<UpdateTaskItemCommandValidator>().As<IValidator<UpdateTaskItemCommandRequestModel>>();
            #endregion
        }
    }
}
