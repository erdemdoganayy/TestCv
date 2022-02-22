using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
   
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);

            //builder.HasMany(e => e.Employees).WithOne(e => e.Country).OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
