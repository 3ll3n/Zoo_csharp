using System.Collections.Generic;
using Zoo.Entities.Animals;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Enclosures
{
    public abstract class Enclosure
    {

        private string name;
        protected List<Animal> animals;

        public abstract void AddAnimal(Animal animal);

        public Enclosure(string name)
        {
            this.name = name;
            this.animals = new List<Animal>();
        }

        public string GetName()
        {
            return name;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public int GetNumberOfAnimals()
        {
            return animals.Count;
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void FeedAnimals(IEdible food)
        {
            foreach (Animal animal in animals)
            {
                animal.Eat(food);
            }
        }
    }

}


