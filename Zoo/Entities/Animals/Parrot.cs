using System;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{
    public class Parrot : Animal, IFly
    {

        public Parrot(string name, int age) : base(name, age)
        {
        }

        public string fly()
        {
            return "I can fly!";
        }

        public string talk()
        {
            return "I can talk!";
        }

        public override void eat(IEdible food)
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


