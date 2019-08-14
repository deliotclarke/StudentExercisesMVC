using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int? StudentId { get; set; }
        // the question mark sets it's default value to null and says that it can be null

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Slack Handle")]
        [MinLength(2)]
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