using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Services.Handlers.Commands
{
    public class AddTaskItemCommandHandler : IRequestHandler<AddTaskItemCommandRequestModel, AddTaskItemCommandResponseModel>
    {
        private readonly ITaskItemRepository taskItemRepository;
        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public AddTaskItemCommandHandler(ITaskItemRepository taskItemRepository, ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskItemRepository = taskItemRepository;
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        public async Task<AddTaskItemCommandResponseModel> Handle(AddTaskItemCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskList = await taskItemRepository.GetByIdAsync(requestModel.TaskListId);

            switch (taskList != null)
            {
                case true: return new AddTaskItemCommandResponseModel(await taskItemRepository.AddAsync(mapper.Map<TaskItemModel>(requestModel)));
                case false: throw new Exception("The Task List doens't exists.");
            }
        }
    }
}
