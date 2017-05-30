using System;
using Zoo.Entities.Animals;

namespace Zoo.Entities.Enclosures
{
    public class Aviary : Enclosure
    {

        public Aviary(string name) : base(name)
        {

        }

        public override void AddAnimal(Animal animal)
        {
            if (animal is IFly)
            {
                animals.Add(animal);
                Console.WriteLine(animal.getName() + " the parrot has been Added to the Aviary!");

            }
            else
            {
                Console.WriteLine("Only parrots in here thanks!");
            }
        }
    }
}


