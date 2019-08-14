using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        public InstructorEditViewModel() { }

        public InstructorEditViewModel(Instructor instructor, List<Cohort> cohortList)
        {
            var Instructor = instructor;
            var Cohorts = cohortList
                .Select(cohort => new SelectListItem { });
        }
    }
}
