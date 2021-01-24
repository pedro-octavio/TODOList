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
    public class UpdateTaskListCommandHandler : IRequestHandler<UpdateTaskListCommandRequestModel>
    {
        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public UpdateTaskListCommandHandler(ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTaskListCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskListExists = await taskListRepository.GetByIdAsync(requestModel.Id) != null;

            switch (taskListExists)
            {
                case true:
                    await taskListRepository.UpdateAsync(mapper.Map<TaskListModel>(requestModel));
                    break;
                case false: throw new Exception("Task List doens't exists");
            }

            return new Unit();
        }
    }
}
