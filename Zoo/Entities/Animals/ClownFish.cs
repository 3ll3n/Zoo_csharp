using System;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{

    public class ClownFish : Animal, ISwim
    {

        public ClownFish(string name, int age) : base(name, age)
        {
        }

        public string swim()
        {
            return "I live in the water and love to swim!";
        }

        public override string breathe()
        {
            return "I can breathe under water!";
        }

        public string blowBubbles()
        {
            return "I can blow bubbles!";
        }

        public override void eat(IEdible food)
        {
            if (food is IPlant)
            {
                belly.Add(food);
                Console.WriteLine("That food was lovely thanks!");
            }
            else
            {
                Console.WriteLine("Yuck!");
            }
        }
    }

}
