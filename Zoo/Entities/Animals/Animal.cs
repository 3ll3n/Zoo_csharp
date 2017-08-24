
using System.Collections.Generic;
using Zoo.Entities.Foods;

namespace Zoo.Entities.Animals
{
    public abstract class Animal
    {

        private string name;
        private int age;
        protected List<IEdible> belly;

        //No default implementation.
        public abstract void Eat(IEdible food);

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.belly = new List<IEdible>();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        //make method virtual in order for subclasses to be able to override - default implementation
        public virtual string Breathe()
        {
            return "I can breathe";
        }

        public int FoodCount()
        {
            return belly.Count;
        }

        public void Poop()
        {
            belly.Clear();
        }
    }
}


