using Microsoft.EntityFrameworkCore;
using Innovators.Models;


namespace Innovators.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext()
        {

        }

        public UserDbContext(DbContextOptions<UserDbContext> options) 
            : base(options)
        {

        }
        public DbSet< Users> Users { get; set; }
    }
}
