using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {
            Educations = new List<Education>();
        }
        [Key]
        public int EmployeeId { get; set; }
  
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; } 

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    
        public string Gender { get; set; } = string.Empty;
     
        public string Village { get; set; } = string.Empty;


        public IList<Education> Educations { get; set; }
    }

}
