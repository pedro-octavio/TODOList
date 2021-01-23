using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;
using TODOList.Data.Models;

namespace TODOList.Data.Services.Repositories
{
    public class TaskListRepository : GenericRepository<TaskListModel>, ITaskListRepository
    {
        private ApplicationDataContext ApplicationDataContext;

        public TaskListRepository(ApplicationDataContext applicationDataContext) : base(applicationDataContext)
        {
            this.ApplicationDataContext = applicationDataContext;
        }

        public override async Task<string> AddAsync(TaskListModel obj)
        {
            var addResult = await ApplicationDataContext.TaskLists.AddAsync(obj);

            return addResult.Entity.Id;
        }
    }
}
