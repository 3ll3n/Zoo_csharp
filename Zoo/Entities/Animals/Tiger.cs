using System;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{
    public class Tiger : Animal, IPredator
    {

        public Tiger(string name, int age) : base(name, age)
        {

        }

        public string Roar()
        {
            return "Roooaaar";
        }

        public string Hunt()
        {
            return "I am a hunter";
        }

        public override void Eat(IEdible food)
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


