using System;

namespace TODOList.Data.Models
{
    /// <summary>
    /// model for represent the TaskLists table
    /// </summary>
    public class TaskListModel
    {
        /// <summary>
        /// constructor for set a TaskListModel
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createDate"></param>
        public TaskListModel(string id, string name, string description, DateTime createDate)
        {
            Id = id;
            Name = name;
            Description = description;
            CreateDate = createDate;
        }

        /// <summary>
        /// constructor for create new TaskListModel
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public TaskListModel(string name, string description)
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
