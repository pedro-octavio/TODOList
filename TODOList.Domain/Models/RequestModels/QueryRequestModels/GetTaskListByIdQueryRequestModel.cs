using MediatR;
using TODOList.Domain.Models.ResponseModels.QueryResponseModels;

namespace TODOList.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetTaskListByIdQueryRequestModel : IRequest<GetTaskListByIdQueryResponseModel>
    {
        public string Id { get; set; }
    }
}
