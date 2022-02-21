using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.DistrictId);
            builder.Property(t => t.DistrictName)
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
