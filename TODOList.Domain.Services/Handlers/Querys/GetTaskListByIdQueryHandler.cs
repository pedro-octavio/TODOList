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
    public class GetTaskListByIdQueryHandler : IRequestHandler<GetTaskListByIdQueryRequestModel, GetTaskListByIdQueryResponseModel>
    {
        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public GetTaskListByIdQueryHandler(ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        public async Task<GetTaskListByIdQueryResponseModel> Handle(GetTaskListByIdQueryRequestModel requestModel, CancellationToken cancellationToken)
        {
            var taskList = await taskListRepository.GetByIdAsync(requestModel.Id);

            switch (taskList != null)
            {
                case true: return mapper.Map<GetTaskListByIdQueryResponseModel>(taskList);
                case false: throw new Exception("Task List doens't exists.");
            }
        }
    }
}
