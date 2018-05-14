using System;
using System.Collections.Generic;

namespace MobilnyGrafik.Models
{
    public interface IAnimalRepository
    {
        void AddAnimal(Animal animal);
        IEnumerable<Animal> GetAllAnimals();
		IEnumerable<Animal> GetAllUserAnimals(string userId);
        Animal GetAnimal(int id);
        void DeleteAnimal(int id);
        void UpdateAnimal(Animal animal);

    }
}
