using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<EmployeeInfo> Employees { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
