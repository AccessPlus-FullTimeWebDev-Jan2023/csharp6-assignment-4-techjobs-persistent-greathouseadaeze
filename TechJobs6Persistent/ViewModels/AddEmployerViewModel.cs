using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
        [Required(ErrorMessage = "Employer Name Required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Names must be between 3 and 20 characters in length.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Employer Name Required")]
        public string? Location { get; set; }
		
	}
}

