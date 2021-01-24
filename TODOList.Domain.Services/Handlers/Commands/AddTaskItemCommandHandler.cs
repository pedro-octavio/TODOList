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
    public class AddTaskItemCommandHandler : IRequestHandler<AddTaskItemCommandRequestModel, AddTaskItemCommandResponseModel>
    {
        private readonly ITaskItemRepository taskItemRepository;
        private readonly IMapper mapper;

        public AddTaskItemCommandHandler(ITaskItemRepository taskItemRepository, IMapper mapper)
        {
            this.taskItemRepository = taskItemRepository;
            this.mapper = mapper;
        }

        public async Task<AddTaskItemCommandResponseModel> Handle(AddTaskItemCommandRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskItemModel = mapper.Map<TaskItemModel>(requestModel);

            return new AddTaskItemCommandResponseModel(await taskItemRepository.AddAsync(taskItemModel));
        }
    }
}
