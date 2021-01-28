using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Services.Handlers.Commands
{
    public class AddTaskListCommandHandler : IRequestHandler<AddTaskListCommandRequestModel, AddTaskListCommandResponseModel>
    {
        public AddTaskListCommandHandler(ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public async Task<AddTaskListCommandResponseModel> Handle(AddTaskListCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskListModel = mapper.Map<TaskListModel>(requestModel);

            return new AddTaskListCommandResponseModel(await taskListRepository.AddAsync(taskListModel));
        }
    }
}
