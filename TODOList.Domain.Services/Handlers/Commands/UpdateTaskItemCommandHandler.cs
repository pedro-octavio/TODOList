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
            var taskItemExists = await taskItemRepository.GetByIdAsync(requestModel.Id) != null;

            switch (taskItemExists)
            {
                case true:
                    await taskItemRepository.UpdateAsync(mapper.Map<TaskItemModel>(requestModel));
                    break;
                case false: throw new Exception("Task Item doens't exists");
            }

            return new Unit();
        }
    }
}
