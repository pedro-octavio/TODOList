using MediatR;
using System.Collections.Generic;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllTaskItemsQueryRequestModel : IRequest<IEnumerable<GetAllTaskItemsQueryResponseModel>>
    {
        public GetAllTaskItemsQueryRequestModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
