using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateTaskItemCommandRequestModel : IRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
