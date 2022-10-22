using Innovators.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;

namespace Innovators.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }

        public DbSet<AssignLecturer> assignLecturers { get; set; }
        public DbSet<InformationTechnology> informationTechnology { get; set; }
        public DbSet<CivilEngineering> civilEngineering { get; set; }

    }
}
