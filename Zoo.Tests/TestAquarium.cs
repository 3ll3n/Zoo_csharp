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
        public void Init()
        {
            aquarium = new Aquarium("Aquarium");
            clownfish = new ClownFish("Flounder", 7);
            tiger = new Tiger("Spartan", 5);
        }

        [TestMethod]
        public void TestAddAnimal()
        {
            aquarium.AddAnimal(clownfish);
            Assert.AreEqual(1, aquarium.GetNumberOfAnimals());
        }

        [TestMethod]
        public void TestCantAddWrongAnimal()
        {
            aquarium.AddAnimal(tiger);
            Assert.AreEqual(0, aquarium.GetNumberOfAnimals());
        }
    }
}