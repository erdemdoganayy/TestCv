using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorAppCRUD.Persistence.Configurations
{

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            //builder.HasOne(e => e.Country).WithMany(e => e.Employees).OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }

}
