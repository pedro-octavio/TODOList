using MediatR;
using System;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddTaskListCommandRequestModel : IRequest<AddTaskListCommandResponseModel>
    {
        public AddTaskListCommandRequestModel(string name, string description)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
    }
}
