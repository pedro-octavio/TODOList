using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Services.Handlers.Commands
{
    public class DeleteTaskItemCommandHandler : IRequestHandler<DeleteTaskItemCommandRequestModel>
    {
        public DeleteTaskItemCommandHandler(ITaskItemRepository taskItemRepository)
        {
            this.taskItemRepository = taskItemRepository;
        }

        private readonly ITaskItemRepository taskItemRepository;

        public async Task<Unit> Handle(DeleteTaskItemCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(requestModel.Id);

            switch (taskItem != null)
            {
                case true:
                    await taskItemRepository.DeleteAsync(taskItem);
                    break;
                case false: throw new Exception("Task Item doens't exists.");
            }

            return new Unit();
        }
    }
}
