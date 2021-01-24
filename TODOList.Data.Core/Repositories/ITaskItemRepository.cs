﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TODOList.Data.Models;

namespace TODOList.Data.Core.Repositories
{
    /// <summary>
    /// interface for access a TaskItems table
    /// </summary>
    public interface ITaskItemRepository : IGenericRepository<TaskItemModel>
    {
        /// <summary>
        /// function for get all rows of table by taskListId
        /// </summary>
        /// <param name="taskListId"></param>
        /// <returns></returns>
        Task<IEnumerable<TaskItemModel>> GetAllAsync(string taskListId);
    }
}
