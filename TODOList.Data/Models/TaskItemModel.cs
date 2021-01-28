using System;

namespace TODOList.Data.Models
{
    /// <summary>
    /// model for represent the TaskItems table
    /// </summary>
    public class TaskItemModel
    {
        /// <summary>
        /// constructor for set a TaskItemModel
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskListId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createDate"></param>
        /// <param name="isDone"></param>
        public TaskItemModel(string id, string taskListId, string name, string description, DateTime createDate, bool isDone)
        {
            Id = id;
            TaskListId = taskListId;
            Name = name;
            Description = description;
            CreateDate = createDate;
            IsDone = isDone;
        }

        /// <summary>
        /// constructor for create a new TaskItemModel
        /// </summary>
        /// <param name="taskListId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public TaskItemModel(string taskListId, string name, string description)
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
