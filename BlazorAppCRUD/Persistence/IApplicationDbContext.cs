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
        DbSet<City> Cities { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<School> Schools { get; set; }
        DbSet<User> Users{ get; set; }
        DbSet<SchoolDepartment> SchoolDepartments { get; set; }
        DbSet<FeedBack> FeedBacks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
