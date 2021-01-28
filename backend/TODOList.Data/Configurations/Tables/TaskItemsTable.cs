using Microsoft.EntityFrameworkCore;
using TODOList.Data.Models;

namespace TODOList.Data.Configurations.Tables
{
    internal static class TaskItemsTable
    {
        /// <summary>
        /// configuration of TaskItems table for TaskItemModel
        /// </summary>
        /// <param name="modelBuilder"></param>
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskItemModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<TaskItemModel>()
                .Property(x => x.TaskListId)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<TaskItemModel>()
               .Property(x => x.Name)
               .HasMaxLength(40)
               .IsRequired();

            modelBuilder.Entity<TaskItemModel>()
               .Property(x => x.Description)
               .HasMaxLength(4200);

            modelBuilder.Entity<TaskItemModel>()
               .Property(x => x.CreateDate)
               .IsRequired();

            modelBuilder.Entity<TaskItemModel>()
              .Property(x => x.IsDone)
              .IsRequired();
        }
    }
}
