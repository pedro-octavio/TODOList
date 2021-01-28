using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteTaskListCommandRequestModel : IRequest
    {
        public string Id { get; set; }
    }
}
