using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalRoster6.Data;
using AnimalRoster6.Models;
using Microsoft.AspNetCore.Mvc;
using AnimalRoster6.ViewModels;

namespace AnimalRoster6.Controllers
{
    public class AnimalsController : Controller
    {
        [HttpGet]
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Animal> animals = new List<Animal>(AnimalData.GetAll());
            return View(animals);
        }

        [HttpGet]
        [Route("Animals/Add")]
        public IActionResult Add()
        {
            AddAnimalViewModel addAnimalViewModel = new AddAnimalViewModel();
            return View(addAnimalViewModel);
        }


        [HttpPost]
        [Route("Animals/Add")]
        public IActionResult Add(AddAnimalViewModel addAnimalViewModel)
        {
            if (ModelState.IsValid)
            {
                Animal animal = new Animal
                {
                    Name = addAnimalViewModel.Name,
                    Species = addAnimalViewModel.Species,
                    Description = addAnimalViewModel.Description,
                    ImgUrl = addAnimalViewModel.ImgUrl
                };

                AnimalData.Add(newAnimal);

                return Redirect("/Animals");
            }

            return View(addAnimalViewModel);
            
        }
    }
}

