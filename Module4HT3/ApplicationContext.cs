using Microsoft.EntityFrameworkCore;
using Module4HT3.EntityConfigurations;

namespace Module4HT3
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            builder.ApplyConfiguration(new EmployeeProjectEntityTypeConfiguration());
            builder.ApplyConfiguration(new OfficeEntityTypeConfiguration());
            builder.ApplyConfiguration(new ProjectEntityTypeConfiguration());
            builder.ApplyConfiguration(new TitleEntityTypeConfiguration());
        }
    }
}
