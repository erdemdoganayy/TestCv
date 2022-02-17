using BlazorAppCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Experience> Experiences { get; set; }
        DbSet<Skill> Skills { get; set; }
        DbSet<Language> Languages { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
