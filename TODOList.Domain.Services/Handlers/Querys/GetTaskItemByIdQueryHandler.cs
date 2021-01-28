using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Services.Handlers.Querys
{
    public class GetTaskItemByIdQueryHandler : IRequestHandler<GetTaskItemByIdQueryRequestModel, GetTaskItemByIdQueryResponseModel>
    {
        public GetTaskItemByIdQueryHandler(ITaskItemRepository taskItemRepository, IMapper mapper)
        {
            this.taskItemRepository = taskItemRepository;
            this.mapper = mapper;
        }

        private readonly ITaskItemRepository taskItemRepository;
        private readonly IMapper mapper;

        public async Task<GetTaskItemByIdQueryResponseModel> Handle(GetTaskItemByIdQueryRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(requestModel.Id);

            switch (taskItem != null)
            {
                case true: return mapper.Map<GetTaskItemByIdQueryResponseModel>(taskItem);
                case false: throw new Exception("Task Item doens't exists.");
            }
        }
    }
}
