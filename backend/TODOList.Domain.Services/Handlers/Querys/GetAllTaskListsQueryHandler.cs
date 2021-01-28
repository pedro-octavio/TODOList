using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Services.Handlers.Querys
{
    public class GetAllTaskListsQueryHandler : IRequestHandler<GetAllTaskListsQueryRequestModel, IEnumerable<GetAllTaskListsQueryResponseModel>>
    {
        public GetAllTaskListsQueryHandler(ITaskListRepository taskListRepository, IMapper mapper)
        {
            this.taskListRepository = taskListRepository;
            this.mapper = mapper;
        }

        private readonly ITaskListRepository taskListRepository;
        private readonly IMapper mapper;

        public async Task<IEnumerable<GetAllTaskListsQueryResponseModel>> Handle(GetAllTaskListsQueryRequestModel requestModel, CancellationToken cancellationToken)
        {
            return mapper.Map<IEnumerable<GetAllTaskListsQueryResponseModel>>(await taskListRepository.GetAllAsync(requestModel.CreateDate));
        }
    }
}
