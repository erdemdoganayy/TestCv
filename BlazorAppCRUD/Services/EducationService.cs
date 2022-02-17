using BlazorAppCRUD.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class EducationService : IEducationService
    {
        private readonly IApplicationDbContext _db;

        public EducationService(IApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Education>> GetEducation()
        {
            return await _db.Educations.ToListAsync();
        }

        public async Task<List<Education>> GetEducationSchool(int Id)
        {
            return await _db.Educations.Where(x => x.EmployeeId == Id).ToListAsync();
        }

        public async Task<bool> Create(Education education)
        {
            _db.Educations.Add(education);
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }

        public async Task<bool> DeleteEducation(int Id)
        {
            _db.Educations.Remove(new Education() { Id = Id });
            await _db.SaveChangesAsync(CancellationToken.None);
            return true;
        }


    }
}
