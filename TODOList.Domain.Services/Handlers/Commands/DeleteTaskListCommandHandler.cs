using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;

namespace TODOList.Domain.Services.Handlers.Commands
{
    public class DeleteTaskListCommandHandler : IRequestHandler<DeleteTaskListCommandRequestModel>
    {
        private readonly ITaskListRepository taskListRepository;

        public DeleteTaskListCommandHandler(ITaskListRepository taskListRepository)
        {
            this.taskListRepository = taskListRepository;
        }

        public async Task<Unit> Handle(DeleteTaskListCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskList = await taskListRepository.GetByIdAsync(requestModel.Id);

            switch (taskList != null)
            {
                case true:
                    await taskListRepository.UpdateAsync(taskList);
                    break;
                case false: throw new Exception("Task List doens't exists.");
            }

            return new Unit();
        }
    }
}
