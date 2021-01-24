using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteTaskItemCommandRequestModel : IRequest
    {
        public DeleteTaskItemCommandRequestModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
