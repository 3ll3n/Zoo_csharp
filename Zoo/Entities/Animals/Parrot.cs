using System;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{
    public class Parrot : Animal, IFly
    {

        public Parrot(string name, int age) : base(name, age)
        {
        }

        public string Fly()
        {
            return "I can fly!";
        }

        public string Talk()
        {
            return "I can talk!";
        }

        public override void Eat(IEdible food)
        {
            if (food is IFruit)
            {
                belly.Add(food);
                Console.WriteLine("Yum!");
            }
            else
            {
                Console.WriteLine("I don't like that!");
            }
        }
    }
}


