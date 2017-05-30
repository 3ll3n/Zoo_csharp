using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Enclosures;
using Zoo.Entities.Foods;

namespace Zoo.Tests
{
    [TestClass]
    public class TestEnclosure
    {
        Enclosure enclosure;

        Tiger tiger;
        Parrot parrot;

        [TestInitialize]
        public void before()
        {
            enclosure = new BigCat("Big Cats");
            tiger = new Tiger("Tony", 8);
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void testGetName()
        {
            Assert.AreEqual("Big Cats", enclosure.getName());
        }

        [TestMethod]
        public void testGetAnimals()
        {
            enclosure.AddAnimal(new Tiger("Timmy", 8));
            enclosure.AddAnimal(new Tiger("Theresa", 8));
            Assert.AreEqual(2, enclosure.getNumberOfAnimals());
        }

        [TestMethod]
        public void testNumberOfAnimals()
        {
            enclosure.AddAnimal(tiger);
            Assert.AreEqual(1, enclosure.getNumberOfAnimals());
        }

        [TestMethod]
        public void testRemoveAnimal()
        {
            enclosure.AddAnimal(tiger);
            enclosure.removeAnimal(tiger);
            Assert.AreEqual(0, enclosure.getNumberOfAnimals());
        }

        [TestMethod]
        public void testFeedAnimal()
        {
            Steak steak = new Steak();
            enclosure.AddAnimal(tiger);

            Tiger tiger2 = new Tiger("Fluffy", 22);

            enclosure.AddAnimal(tiger2);
            enclosure.feedAnimals(steak);

            Assert.AreEqual(1, tiger.foodCount());
            Assert.AreEqual(1, tiger2.foodCount());
        }
    }
}