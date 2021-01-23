using Microsoft.EntityFrameworkCore;
using TODOList.Data.Models;

namespace TODOList.Data.Configurations.Tables
{
    internal static class TaskListsTable
    {
        /// <summary>
        /// configuration of TaskLists table for TaskListModel
        /// </summary>
        /// <param name="modelBuilder"></param>
        internal static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskListModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<TaskListModel>()
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<TaskListModel>()
               .Property(x => x.Description)
               .HasMaxLength(4200);

            modelBuilder.Entity<TaskListModel>()
               .Property(x => x.CreateDate)
               .IsRequired();
        }
    }
}
