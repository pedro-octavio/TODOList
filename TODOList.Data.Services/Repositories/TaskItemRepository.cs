using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;

namespace TODOList.Data.Services.Repositories
{
    public class TaskItemRepository : GenericRepository<TaskItemModel>, ITaskItemRepository
    {
        private readonly ApplicationDataContext applicationDataContext;

        public TaskItemRepository(ApplicationDataContext applicationDataContext) : base(applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<TaskItemModel>> GetAllAsync(string taskListId)
        {
            return await applicationDataContext.TaskItems.Where(x => x.TaskListId == taskListId).ToListAsync();
        }

        public override async Task<string> AddAsync(TaskItemModel obj)
        {
            var addResult = await applicationDataContext.TaskItems.AddAsync(obj);

            return addResult.Entity.Id;
        }
    }
}
