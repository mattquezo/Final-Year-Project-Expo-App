using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace DCUExpoApp.Models
{
    public class ExpoContext : DbContext
    {
        public DbSet<ExpoProject> Projects { get; set; }
        public DbSet<ProjectStudent> Students { get; set; }

        public DbSet<ProjectArea> ProjectAreas { get; set; }
        public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
        public DbSet<StudentProgramme> StudentProgrammes { get; set; }

        protected readonly IConfiguration Configuration;

        public ExpoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("ExpoDatabase"));
        }
    }
}