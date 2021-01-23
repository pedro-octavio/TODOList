using TODOList.Data.Models;

namespace TODOList.Data.Core.Repositories
{
    /// <summary>
    /// interface for access a TaskLists table
    /// </summary>
    public interface ITaskListRepository : IGenericRepository<TaskListModel>
    {

    }
}
