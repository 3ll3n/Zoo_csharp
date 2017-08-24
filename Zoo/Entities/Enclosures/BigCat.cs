using System;
using Zoo.Entities.Animals;

namespace Zoo.Entities.Enclosures
{
    public class BigCat : Enclosure
    {

        public BigCat(string name) : base(name)
        {
        }

        public override void AddAnimal(Animal animal)
        {
            if (animal is IPredator)
            {
                animals.Add(animal);
                Console.WriteLine(animal.GetName() + " the tiger has been Added to the enclosure!");
            }
            else
            {
                Console.WriteLine("Only tigers in here thanks!");
            }
        }
    }

}


