using MediatR;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetTaskItemByIdQueryRequestModel : IRequest<GetTaskItemByIdQueryResponseModel>
    {
        public GetTaskItemByIdQueryRequestModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
