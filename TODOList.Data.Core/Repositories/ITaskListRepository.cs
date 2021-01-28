using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TODOList.Data.Models;

namespace TODOList.Data.Core.Repositories
{
    /// <summary>
    /// interface for access a TaskLists table
    /// </summary>
    public interface ITaskListRepository : IGenericRepository<TaskListModel>
    {
        /// <summary>
        /// function for get all rows of tabel by create date
        /// </summary>
        /// <param name="createDate"></param>
        /// <returns></returns>
        Task<IEnumerable<TaskListModel>> GetAllAsync(DateTime? createDate);
    }
}
