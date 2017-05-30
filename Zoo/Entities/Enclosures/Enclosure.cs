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

        public string getName()
        {
            return name;
        }

        public List<Animal> getAnimals()
        {
            return animals;
        }

        public int getNumberOfAnimals()
        {
            return animals.Count;
        }

        public void removeAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void feedAnimals(IEdible food)
        {
            foreach (Animal animal in animals)
            {
                animal.eat(food);
            }
        }
    }

}


