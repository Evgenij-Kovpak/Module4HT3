using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HT3.Entities;

namespace Module4HT3.EntityConfigurations
{
    public class EmployeeProjectEntityTypeConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(ep => ep.EmployeeProjectId);

            builder.Property(ep => ep.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(ep => ep.Rate).IsRequired().HasColumnType("money");
            builder.Property(ep => ep.StartedDate).IsRequired().HasMaxLength(7);

            builder.HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(ep => ep.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ep => ep.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(ep => ep.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
