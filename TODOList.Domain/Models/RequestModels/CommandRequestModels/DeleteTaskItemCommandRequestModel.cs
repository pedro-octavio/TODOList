using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteTaskItemCommandRequestModel : IRequest
    {
        public string Id { get; set; }
    }
}
