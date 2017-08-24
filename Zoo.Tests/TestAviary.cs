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
        public void Init()
        {
            aviary = new Aviary("Aviary");
            parrot = new Parrot("Rio", 10);
            clownfish = new ClownFish("Flipper", 3);

        }

        [TestMethod]
        public void TestAddAnimals()
        {
            aviary.AddAnimal(parrot);
            Assert.AreEqual(1, aviary.GetNumberOfAnimals());
        }

        [TestMethod]
        public void TestCantAddWrongAnimal()
        {
            aviary.AddAnimal(clownfish);
            Assert.AreEqual(0, aviary.GetNumberOfAnimals());
        }
    }
}