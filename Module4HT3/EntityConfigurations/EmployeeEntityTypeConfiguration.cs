using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HT3.Entities;

namespace Module4HT3.EntityConfigurations
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);

            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired().HasMaxLength(7);
            builder.Property(e => e.DateOfBirth).HasColumnType("date");

            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Title)
                .WithMany(t => t.Employees)
                .HasForeignKey(e => e.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
