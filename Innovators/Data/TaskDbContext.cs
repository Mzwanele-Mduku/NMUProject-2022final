using Innovators.Models;
using Microsoft.EntityFrameworkCore;

namespace Innovators.Data
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext()
        {

        }

        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {

        }
        public DbSet<Task> Task { get; set; }
    }
}

