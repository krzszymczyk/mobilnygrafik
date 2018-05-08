using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobilnyGrafik.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobilnyGrafik.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _repository;
        public AnimalController(IAnimalRepository repository)
        {
            _repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var animals = _repository.GetAllAnimals();
            return View(animals);
        }
    }
}
