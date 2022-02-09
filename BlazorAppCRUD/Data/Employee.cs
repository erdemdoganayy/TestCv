namespace BlazorAppCRUD.Data
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Educations = new List<Education>();
        }

        public int Id { get; set; }
  
        public string Name { get; set; }
        public string Email { get; set; }

        public int Age { get; set; } 

        public string City { get; set; }

        public string Country { get; set; }
    
        public string Gender { get; set; }
     
        public string Village { get; set; }


        public IList<Education> Educations { get; set; }
    }

}
