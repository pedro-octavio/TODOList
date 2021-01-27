using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;

namespace TODOList.Data.Services.Repositories
{
    public class TaskItemRepository : GenericRepository<TaskItemModel>, ITaskItemRepository
    {
        public TaskItemRepository(ApplicationDataContext applicationDataContext) : base(applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        private readonly ApplicationDataContext applicationDataContext;

        public async Task<IEnumerable<TaskItemModel>> GetAllAsync(DateTime? createDate, string taskListId)
        {
            var taskLists = await applicationDataContext.TaskItems.Where(x => x.TaskListId == taskListId).ToListAsync();

            if (createDate != null) taskLists = taskLists.Where(x => x.CreateDate >= createDate).ToList();

            return taskLists;
        }

        public override async Task<string> AddAsync(TaskItemModel obj)
        {
            var addResult = await applicationDataContext.TaskItems.AddAsync(obj);

            await applicationDataContext.SaveChangesAsync();

            return addResult.Entity.Id;
        }
    }
}
