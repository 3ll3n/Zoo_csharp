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
        public void Init()
        {
            enclosure = new BigCat("Big Cats");
            tiger = new Tiger("Tony", 8);
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void TestGetName()
        {
            Assert.AreEqual("Big Cats", enclosure.GetName());
        }

        [TestMethod]
        public void TestGetAnimals()
        {
            enclosure.AddAnimal(new Tiger("Timmy", 8));
            enclosure.AddAnimal(new Tiger("Theresa", 8));
            Assert.AreEqual(2, enclosure.GetNumberOfAnimals());
        }

        [TestMethod]
        public void TestNumberOfAnimals()
        {
            enclosure.AddAnimal(tiger);
            Assert.AreEqual(1, enclosure.GetNumberOfAnimals());
        }

        [TestMethod]
        public void TestRemoveAnimal()
        {
            enclosure.AddAnimal(tiger);
            enclosure.RemoveAnimal(tiger);
            Assert.AreEqual(0, enclosure.GetNumberOfAnimals());
        }

        [TestMethod]
        public void TestFeedAnimal()
        {
            Steak steak = new Steak();
            enclosure.AddAnimal(tiger);

            Tiger tiger2 = new Tiger("Fluffy", 22);

            enclosure.AddAnimal(tiger2);
            enclosure.FeedAnimals(steak);

            Assert.AreEqual(1, tiger.FoodCount());
            Assert.AreEqual(1, tiger2.FoodCount());
        }
    }
}