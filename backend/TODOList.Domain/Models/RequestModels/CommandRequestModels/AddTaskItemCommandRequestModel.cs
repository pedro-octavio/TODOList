using MediatR;
using System;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddTaskItemCommandRequestModel : IRequest<AddTaskItemCommandResponseModel>
    {
        public AddTaskItemCommandRequestModel()
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);

            CreateDate = DateTime.Now;
            IsDone = false;
        }

        public string Id { get; private set; }
        public string TaskListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; private set; }
        public bool IsDone { get; private set; }
    }
}
