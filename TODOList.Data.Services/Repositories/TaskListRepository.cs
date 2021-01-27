using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;

namespace TODOList.Data.Services.Repositories
{
    public class TaskListRepository : GenericRepository<TaskListModel>, ITaskListRepository
    {
        private ApplicationDataContext applicationDataContext;

        public TaskListRepository(ApplicationDataContext applicationDataContext) : base(applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<TaskListModel>> GetAllAsync(DateTime? createDate)
        {
            switch (createDate != null)
            {
                case true:
                    {
                        return await applicationDataContext.TaskLists.Where(x => x.CreateDate >= createDate).ToListAsync();
                    }
                case false:
                    {
                        return await applicationDataContext.TaskLists.ToListAsync();
                    }
            }
        }

        public override async Task<string> AddAsync(TaskListModel obj)
        {
            var addResult = await applicationDataContext.TaskLists.AddAsync(obj);

            await applicationDataContext.SaveChangesAsync();

            return addResult.Entity.Id;
        }
    }
}
