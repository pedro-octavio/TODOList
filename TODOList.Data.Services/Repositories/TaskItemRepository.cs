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

        public override async Task<string> AddAsync(TaskItemModel obj)
        {
            var addResult = await applicationDataContext.TaskItems.AddAsync(obj);

            return addResult.Entity.Id;
        }
    }
}
