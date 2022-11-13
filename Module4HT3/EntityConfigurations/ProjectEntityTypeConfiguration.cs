using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HT3.Entities;

namespace Module4HT3.EntityConfigurations
{
    public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);

            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired().HasMaxLength(7);
        }
    }
}
