using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HT3.Entities;

namespace Module4HT3.EntityConfigurations
{
    public class OfficeEntityTypeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);

            builder.Property(o => o.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.Title).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasMaxLength(100);
        }
    }
}
