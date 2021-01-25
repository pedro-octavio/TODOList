using MediatR;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetTaskItemByIdQueryRequestModel : IRequest<GetTaskItemByIdQueryResponseModel>
    {
        public string Id { get; set; }
    }
}
