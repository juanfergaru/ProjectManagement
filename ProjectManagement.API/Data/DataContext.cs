using Microsoft.EntityFrameworkCore;
using ProjectManagement.Shared.Entities;

namespace ProjectManagement.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<InvestigationProject> InvestigationProjects { get; set; }

        //investigator
        public DbSet<Investigator> Investigators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InvestigationProject>().HasIndex(c => c.NameProject).IsUnique();
            //investigator
            modelBuilder.Entity<Investigator>().HasIndex(c => c.NameInvestigador).IsUnique();
        }



    }
}
