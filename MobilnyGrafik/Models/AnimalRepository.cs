using System;
using System.Collections.Generic;
using MobilnyGrafik.DataAccessLayer;

namespace MobilnyGrafik.Models
{
    public class AnimalRepository:IAnimalRepository
    {
        private readonly AppDbContext _context;
        public AnimalRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void DeleteAnimal(int id)
        {
            Animal animal = GetAnimal(id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            var animals = _context.Animals;
            return animals;
        }

        public Animal GetAnimal(int id)
        {
            var animal = _context.Animals.Find(id);
            return animal;
        }

        public void UpdateAnimal(Animal animal)
        {
            _context.Animals.Update(animal);
            _context.SaveChanges();
        }
    }
}
