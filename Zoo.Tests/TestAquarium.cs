using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Enclosures;

namespace Zoo.Tests
{
    [TestClass]
    public class TestAquarium
    {
        Enclosure aquarium;
        Animal clownfish;
        Animal tiger;

        [TestInitialize]
        public void before()
        {
            aquarium = new Aquarium("Aquarium");
            clownfish = new ClownFish("Flounder", 7);
            tiger = new Tiger("Spartan", 5);
        }

        [TestMethod]
        public void testAddAnimal()
        {
            aquarium.AddAnimal(clownfish);
            Assert.AreEqual(1, aquarium.getNumberOfAnimals());
        }

        [TestMethod]
        public void testCantAddWrongAnimal()
        {
            aquarium.AddAnimal(tiger);
            Assert.AreEqual(0, aquarium.getNumberOfAnimals());
        }
    }
}