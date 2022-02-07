using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    
        public class EmployeeInfoConfiguration : IEntityTypeConfiguration<EmployeeInfo>
        {
            public void Configure(EntityTypeBuilder<EmployeeInfo> builder)
            {
                builder.Property(t => t.Name)
                    .HasMaxLength(200)
                    .IsRequired();
            }
        }
    
}
