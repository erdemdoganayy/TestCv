using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    public class LanguageConfiguration
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(t => t.LanguageName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
