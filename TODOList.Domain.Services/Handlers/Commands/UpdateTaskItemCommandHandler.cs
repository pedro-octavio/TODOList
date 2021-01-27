using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Services.Handlers.Commands
{
    public class UpdateTaskItemCommandHandler : IRequestHandler<UpdateTaskItemCommandRequestModel>
    {
        private readonly ITaskItemRepository taskItemRepository;
        private readonly IMapper mapper;

        public UpdateTaskItemCommandHandler(ITaskItemRepository taskItemRepository, IMapper mapper)
        {
            this.taskItemRepository = taskItemRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTaskItemCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(requestModel.Id);

            switch (taskItem != null)
            {
                case true:
                    await taskItemRepository.UpdateAsync(new TaskItemModel(requestModel.Id, taskItem.TaskListId, requestModel.Name, requestModel.Description, taskItem.CreateDate, requestModel.IsDone));
                    break;
                case false: throw new Exception("Task Item doens't exists");
            }

            return new Unit();
        }
    }
}
