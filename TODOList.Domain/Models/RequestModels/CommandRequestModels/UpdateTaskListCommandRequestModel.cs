using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateTaskListCommandRequestModel : IRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
