using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HT3.Entities;

namespace Module4HT3.EntityConfigurations
{
    public class TitleEntityTypeConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);

            builder.Property(t => t.TitleId).HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
        }
    }
}
