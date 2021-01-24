using MediatR;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateTaskListCommandRequestModel : IRequest
    {
        public UpdateTaskListCommandRequestModel(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
