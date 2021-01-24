using MediatR;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteTaskItemCommandRequestModel : IRequest<DeleteTaskItemCommandResponseModel>
    {
        public DeleteTaskItemCommandRequestModel(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
