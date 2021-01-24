﻿using MediatR;
using System;
using TODOList.Domain.Models.ResponseModels.CommandResponseModels;

namespace TODOList.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddTaskItemCommandRequestModel : IRequest<AddTaskItemCommandResponseModel>
    {
        public AddTaskItemCommandRequestModel(string taskListId, string name, string description)
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            TaskListId = taskListId;
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
            IsDone = false;
        }

        public string Id { get; private set; }
        public string TaskListId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
        public bool IsDone { get; private set; }
    }
}
