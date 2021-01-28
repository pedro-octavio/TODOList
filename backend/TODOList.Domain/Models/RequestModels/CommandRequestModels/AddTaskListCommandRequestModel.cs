using MediatR;
using System;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddTaskListCommandRequestModel : IRequest<AddTaskListCommandResponseModel>
    {
        public AddTaskListCommandRequestModel()
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            CreateDate = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; private set; }
    }
}
