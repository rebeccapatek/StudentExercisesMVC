﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public int StudentId { get; set; }
        [Display(Name = "First Name")]
        [Required]

        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]

        public string LastName { get; set; }
        [Display(Name="Cohort")]
        [Required]
        public int CohortId { get; set; }
        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }
        public List <SelectListItem> CohortOptions { get; set; }
    }
}
