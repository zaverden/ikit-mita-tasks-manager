using Microsoft.EntityFrameworkCore;
using TasksManager.Entities;

namespace TasksManager.Db
{
    public class TasksContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagsInTask> TagsInTasks { get; set; }
    }
}
