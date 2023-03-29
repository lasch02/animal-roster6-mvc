using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalRoster6.ViewModels
{
    public class AddAnimalViewModel
    {
        [Required(ErrorMessage = "Name required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Species required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 characters")]
        public string? Species { get; set; }

        [Required(ErrorMessage = "Description required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 characters")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Name required")]
        [StringLength(100, ErrorMessage = "Invalid URL format")]
        public string? ImgUrl { get; set; }
    }
}
