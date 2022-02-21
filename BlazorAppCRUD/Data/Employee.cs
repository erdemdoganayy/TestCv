namespace BlazorAppCRUD.Data
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Educations = new List<Education>();
            Experiences = new List<Experience>();
            Skills = new List<Skill>();
            Languages = new List<Language>();
     }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }

        public int EmployeeAge { get; set; }

        public int EmployeeCityId { get; set; }

        public string EmployeeCountry { get; set; }

        public string EmployeeGender { get; set; }

        public string EmployeeVillage { get; set; }



        public IList<Education> Educations { get; set; }
        public IList<Experience> Experiences { get; set; }
        public IList<Skill> Skills { get; set; }
        public IList<Language> Languages { get; set; }
  
    }

}
