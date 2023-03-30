using AnimalRoster6.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public AnimalHandler Handler { get; set; }

        public List<SelectListItem> AnimalHandlers { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(AnimalHandler.Gerard.ToString(), ((int) AnimalHandler.Gerard).ToString()), //this eventuall becomes ("Gerard", "0")
            new SelectListItem(AnimalHandler.Patrick.ToString(), ((int) AnimalHandler.Patrick).ToString())
            new SelectListItem(AnimalHandler.Nasya.ToString(), ((int) AnimalHandler.Nasya).ToString())
            new SelectListItem(AnimalHandler.Cory.ToString(), ((int) AnimalHandler.Cory).ToString())
            new SelectListItem(AnimalHandler.Maggie.ToString(), ((int) AnimalHandler.Maggie).ToString())
            new SelectListItem(AnimalHandler.Justus.ToString(), ((int) AnimalHandler.Justus).ToString()),
            new SelectListItem(AnimalHandler.Rick.ToString(), ((int) AnimalHandler.Rick).ToString()),
            new SelectListItem(AnimalHandler.Ashley.ToString(), ((int) AnimalHandler.Ashley).ToString()),
            new SelectListItem(AnimalHandler.Mario.ToString(), ((int) AnimalHandler.Mario).ToString()),
            new SelectListItem(AnimalHandler.Sarah.ToString(), ((int) AnimalHandler.Sarah).ToString()),
            new SelectListItem(AnimalHandler.Jose.ToString(), ((int) AnimalHandler.Jose).ToString()),

        };
    }
}
