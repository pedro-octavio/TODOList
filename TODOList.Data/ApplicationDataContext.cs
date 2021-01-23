using Microsoft.EntityFrameworkCore;
using TODOList.Data.Configurations.Tables;
using TODOList.Data.Models;

namespace TODOList.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TaskListsTable.Configure(modelBuilder);
            TaskItemsTable.Configure(modelBuilder);
        }

        public DbSet<TaskListModel> TaskLists { get; set; }
        public DbSet<TaskItemModel> TaskItems { get; set; }
    }
}
