using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Employee).WithMany(e => e.Experiences).OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.CompanyName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
