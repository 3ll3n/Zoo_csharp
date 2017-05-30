using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Entities.Animals;
using Zoo.Entities.Enclosures;
using Zoo.Entities.Foods;


namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities.Zoo zoo = new Entities.Zoo("Animal Sanctuary");

            Enclosure tigerEnclosure = null;
            Enclosure parrotEnclosure = null;
            Enclosure clownfishEnclosure = null;

            Animal tiger = new Tiger("Tony", 8);
            Animal clownfish = new ClownFish("Nemo", 2);
            Animal parrot = new Parrot("Polymorphism", 20);

            Steak steak = new Steak();
            Algae algae = new Algae();
            Seeds seeds = new Seeds();

            var running = true;

            while (running)
            {

                Console.WriteLine("Type 1 to Add a new enclosure.");
                Console.WriteLine("Type 2 to Add an animal to an enclosure.");
                Console.WriteLine("Type 3 to choose an animal to feed.");
                Console.WriteLine("Type 4 to feed the animal.");
                Console.WriteLine("Type 5 to exit.");

                var input = Console.ReadLine();
                var option = Convert.ToInt32(input);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Which enclosure would you like to Add?: ");
                        Console.WriteLine("Type 1 for Big Cats");
                        Console.WriteLine("Type 2 for Aquarium");
                        Console.WriteLine("Type 3 for Aviary");
                        
                        input = Console.ReadLine();
                        option = Convert.ToInt32(input);

                        switch (option)
                        {
                            case 1:
                                tigerEnclosure = new BigCat("Big Cats");
                                zoo.AddEnclosure(tigerEnclosure);
                                Console.WriteLine("Big Cats enclosure Added!");
                                break;

                            case 2:
                                clownfishEnclosure = new Aquarium("Aquarium");
                                zoo.AddEnclosure(clownfishEnclosure);
                                Console.WriteLine("Aquarium Added!");
                                break;

                            case 3:
                                parrotEnclosure = new Aviary("Aviary");
                                zoo.AddEnclosure(parrotEnclosure);
                                Console.WriteLine("Aviary Added!");
                                break;
                        }
                        break;
                    case 2:

                        Console.WriteLine("The animals you can choose to Add to an enclosure are: ");
                        Console.WriteLine("Type 1 for Tiger");
                        Console.WriteLine("Type 2 for Clownfish");
                        Console.WriteLine("Type 3 for Parrot");

                        input = Console.ReadLine();
                        option = Convert.ToInt32(input);

                        switch (option)
                        {

                            case 1:
                                if (tigerEnclosure != null)
                                {
                                    tigerEnclosure.AddAnimal(tiger);
                                }
                                else
                                {
                                    Console.WriteLine("Tigers are not allowed in this enclosure!");
                                }
                                break;

                            case 2:
                                if (clownfishEnclosure != null)
                                {
                                    clownfishEnclosure.AddAnimal(clownfish);
                                }
                                else
                                {
                                    Console.WriteLine("ClownFish are not allowed in this enclosure!");
                                }
                                break;

                            case 3:
                                if (parrotEnclosure != null)
                                {
                                    parrotEnclosure.AddAnimal(parrot);
                                }
                                else
                                {
                                    Console.WriteLine("Parrots are not allowed in this enclosure");
                                }
                                break;
                        }

                        break;
                    case 3:

                        Console.WriteLine("Please select the animal you would like to feed: ");
                        Console.WriteLine("Type 1 for Tiger");
                        Console.WriteLine("Type 2 for ClownFish");
                        Console.WriteLine("Type 3 for Parrot");

                        input = Console.ReadLine();
                        option = Convert.ToInt32(input);

                        switch (option)
                        {

                            case 1:
                                List<Animal> tigers = tigerEnclosure.getAnimals();
                                foreach (Animal tiger1 in tigers)
                                {
                                    Console.WriteLine(tiger1.getName());
                                }

                                break;

                            case 2:
                                List<Animal> clownFish = clownfishEnclosure.getAnimals();
                                foreach (Animal clownfish1 in clownFish)
                                {
                                    Console.WriteLine(clownfish1.getName());
                                }

                                break;

                            case 3:
                                List<Animal> parrots = parrotEnclosure.getAnimals();
                                foreach (Animal parrot1 in parrots)
                                {
                                    Console.WriteLine(parrot1.getName());
                                }
                                break;
                        }

                        break;
                    case 4:

                        Console.WriteLine("Please select the food you would like to feed to the animal: ");
                        Console.WriteLine("Type 1 for Steak");
                        Console.WriteLine("Type 2 for Algae");
                        Console.WriteLine("Type 3 for Seeds");

                        input = Console.ReadLine();
                        option = Convert.ToInt32(input);

                        switch (option)
                        {
                            case 1:
                                tiger.eat(steak);
                                break;

                            case 2:
                                clownfish.eat(algae);
                                break;

                            case 3:
                                parrot.eat(seeds);
                                break;
                        }

                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }
    }
}
