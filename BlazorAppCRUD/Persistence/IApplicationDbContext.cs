using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<EmployeeInfo> Employees { get; set; }
        DbSet<Education> Education { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
