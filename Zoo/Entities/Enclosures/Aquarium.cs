using System;
using Zoo.Entities.Animals;

namespace Zoo.Entities.Enclosures
{
    public class Aquarium : Enclosure
    {

        public Aquarium(string name) : base(name)
        {
        }

        public override void AddAnimal(Animal animal)
        {
            if (animal is ISwim)
            {
                animals.Add(animal);
                Console.WriteLine(animal.getName() + " the clownfish has been Added to the Aquarium!");

            }
            else
            {
                Console.WriteLine("Only clownfish in here thanks!");
            }
        }
    }
}
    