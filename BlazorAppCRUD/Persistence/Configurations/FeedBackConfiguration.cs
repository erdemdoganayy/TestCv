using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlazorAppCRUD.Persistence.Configurations
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Subject)
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
