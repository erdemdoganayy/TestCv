using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    public class SchoolDepartmentConfiguration : IEntityTypeConfiguration<SchoolDepartment>
    {
        public void Configure(EntityTypeBuilder<SchoolDepartment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();

        }
    }
}
