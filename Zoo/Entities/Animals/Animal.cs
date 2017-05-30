
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
        public abstract void eat(IEdible food);

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.belly = new List<IEdible>();
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        //make method virtual in order for subclasses to be able to override - default implementation
        public virtual string breathe()
        {
            return "I can breathe";
        }

        public int foodCount()
        {
            return belly.Count;
        }

        public void poop()
        {
            belly.Clear();
        }
    }
}


