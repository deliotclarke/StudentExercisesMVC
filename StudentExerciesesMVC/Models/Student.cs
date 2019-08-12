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
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        [Required]
        [Display(Name = "Cohort ID")]
        public int CohortId { get; set; }
        [Display(Name = "Full Name")]
        public String FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}