using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExerciesesMVC.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string SlackHandle { get; set; }
        [Required]
        public int CohortId { get; set; }
        public String FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}