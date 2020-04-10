using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorEditView_Model
    
         {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Slack Name")]
        [Required]
        public string SlackHandle { get; set; }
        [Display(Name = "Specialty")]
        [Required]
        public string Specialty { get; set; }
        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }


    }
}
