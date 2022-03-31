using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BlazorAppCRUD.Persistence.Configurations
{
    public class ForgotPasswordConfiguration : IEntityTypeConfiguration<ForgotPassword>
    {
        public void Configure(EntityTypeBuilder<ForgotPassword> builder)
        {
            builder.HasKey(e => e.Id);

        }
    }
}

