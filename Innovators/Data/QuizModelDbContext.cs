using Innovators.Models;
using Microsoft.EntityFrameworkCore;

namespace Innovators.Data
{
    public class QuizModelDbContext:DbContext
    {

        public QuizModelDbContext()
        {
        }

        public QuizModelDbContext(DbContextOptions<QuizModelDbContext> options):base(options)
        {

        }

        public DbSet<QuizModel> QuizModel { get; set; }


    }
}
