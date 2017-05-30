using System;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{
    public class Tiger : Animal, IPredator
    {

        public Tiger(string name, int age) : base(name, age)
        {

        }

        public string roar()
        {
            return "Roooaaar";
        }

        public string hunt()
        {
            return "I am a hunter";
        }

        public override void eat(IEdible food)
        {
            if (food is IMeat)
            {
                belly.Add(food);
                Console.WriteLine("Thank you for my steak!");
            }
            else
            {
                Console.WriteLine("Yuck! I want steak!");
            }
        }
    }

}


