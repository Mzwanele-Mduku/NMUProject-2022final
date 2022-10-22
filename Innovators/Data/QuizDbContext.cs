using Innovators.Models;
using Microsoft.EntityFrameworkCore;

namespace Innovators.Data
{
    public class QuizDbContext:DbContext
    {
        public QuizDbContext()
        {
        }

        public QuizDbContext(DbContextOptions<QuizDbContext>options): base(options)
        {

        }

        public DbSet <Quiz> Quizes { get; set; }
    }
}
