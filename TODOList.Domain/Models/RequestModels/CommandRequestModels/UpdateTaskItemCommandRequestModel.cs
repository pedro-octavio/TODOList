using MediatR;
using System;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateTaskItemCommandRequestModel : IRequest
    {
        public UpdateTaskItemCommandRequestModel(string id, string taskListId, string name, string description, DateTime createDate, bool isDone)
        {
            Id = id;
            TaskListId = taskListId;
            Name = name;
            Description = description;
            CreateDate = createDate;
            IsDone = isDone;
        }

        public string Id { get; private set; }
        public string TaskListId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
        public bool IsDone { get; private set; }
    }
}
