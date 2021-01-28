using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Services.Handlers.Querys
{
    public class GetAllTaskItemsQueryHandler : IRequestHandler<GetAllTaskItemsQueryRequestModel, IEnumerable<GetAllTaskItemsQueryResponseModel>>
    {
        public GetAllTaskItemsQueryHandler(ITaskItemRepository taskItemRepository, ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskItemRepository = taskItemRepository;
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        private readonly ITaskItemRepository taskItemRepository;
        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public async Task<IEnumerable<GetAllTaskItemsQueryResponseModel>> Handle(GetAllTaskItemsQueryRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskList = await taskListRepository.GetByIdAsync(requestModel.TaskListId);

            switch (taskList != null)
            {
                case true: return mapper.Map<IEnumerable<GetAllTaskItemsQueryResponseModel>>(await taskItemRepository.GetAllAsync(requestModel.CreateDate, requestModel.TaskListId));
                case false: throw new Exception("Task List doens't exists.");
            }
        }
    }
}
