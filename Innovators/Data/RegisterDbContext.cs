using Innovators.Models;
using Microsoft.EntityFrameworkCore;

namespace Innovators.Data
{
    public class RegisterDbContext:DbContext

    {
        public RegisterDbContext()
        {

        }
        public RegisterDbContext(DbContextOptions<RegisterDbContext>options):base (options)
        {

        }
        public DbSet<Register> Register { get; set; }

    }
}
