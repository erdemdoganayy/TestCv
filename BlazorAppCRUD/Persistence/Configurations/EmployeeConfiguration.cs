using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{
    
        public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                builder.HasKey(e => e.EmployeeId);
                
                builder.Property(t => t.EmployeeName)
                    .HasMaxLength(200)
                    .IsRequired();
            }
        }
    
}
