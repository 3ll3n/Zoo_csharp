using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Enclosures;

namespace Zoo.Tests
{
    [TestClass]
    public class TestAviary
    {
        Enclosure aviary;
        Animal parrot;
        Animal clownfish;

        [TestInitialize]
        public void before()
        {
            aviary = new Aviary("Aviary");
            parrot = new Parrot("Rio", 10);
            clownfish = new ClownFish("Flipper", 3);

        }

        [TestMethod]
        public void testAddAnimals()
        {
            aviary.AddAnimal(parrot);
            Assert.AreEqual(1, aviary.getNumberOfAnimals());
        }

        [TestMethod]
        public void testCantAddWrongAnimal()
        {
            aviary.AddAnimal(clownfish);
            Assert.AreEqual(0, aviary.getNumberOfAnimals());
        }
    }
}