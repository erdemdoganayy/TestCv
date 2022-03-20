﻿using System.ComponentModel.DataAnnotations;

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

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string CareerObjective { get; set; }
        public string ShortInfo { get; set; }
        public string JobDescription { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }

        //public int UserId { get; set; }
        //public User User { get; set; }

        public IList<Education> Educations { get; set; }
        public IList<Experience> Experiences { get; set; }
        public IList<Skill> Skills { get; set; }
        public IList<Language> Languages { get; set; }
    

    }

}
