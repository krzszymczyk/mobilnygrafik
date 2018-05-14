using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobilnyGrafik.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobilnyGrafik.Controllers
{
    [Authorize]
    public class AnimalController : Controller
    {
		private readonly UserManager<AppUser> _userManager;
        private readonly IAnimalRepository _repository;
		public AnimalController(IAnimalRepository repository,UserManager<AppUser> userManager)
        {
            _repository = repository;
			_userManager = userManager;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
			var animals = _repository.GetAllUserAnimals(_userManager.GetUserId(HttpContext.User));
            return View(animals);
        }
        
		public IActionResult Add()
		{
			return View();
		}

        [HttpPost]
		public IActionResult Add(Animal animal)
		{
			if (ModelState.IsValid)
			{
				
				var userAnimal = _repository.GetAnimal(animal.Id);
                if (userAnimal == null)
				{
					animal.UserId = _userManager.GetUserId(HttpContext.User);
                    _repository.AddAnimal(animal);
					return RedirectToAction("Index", "Animal");
    
                }
				else
				{
					ModelState.AddModelError("", "Zwierzak juz istnieje");
				}
			}
			ModelState.AddModelError("", "Datas are not valid");
			return View(animal);
		}
        
		public IActionResult Delete(int id)
		{
			_repository.DeleteAnimal(id);
			return RedirectToAction("Index", "Animal");
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			var animal = _repository.GetAnimal(id);
			return View(animal);
		}
        [HttpPost]
		public IActionResult Edit(Animal animal)
		{
			if(ModelState.IsValid){
				animal.UserId = _userManager.GetUserId(HttpContext.User);
				_repository.UpdateAnimal(animal);
				return RedirectToAction("Index", "Animal");
			}
			return View(animal);
		}
    }
}
