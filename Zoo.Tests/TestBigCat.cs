using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Enclosures;

namespace Zoo.Tests
{
    [TestClass]
    public class TestBigCat
    {
        Enclosure bigcat;
        Animal tiger;
        Animal clownfish;

        [TestInitialize]
        public void before()
        {
            bigcat = new BigCat("Big Cats");
            tiger = new Tiger("Scar", 15);
            clownfish = new ClownFish("Coco", 7);
        }

        [TestMethod]
        public void testAddAnimals()
        {
            bigcat.AddAnimal(tiger);
            Assert.AreEqual(1, bigcat.getNumberOfAnimals());
        }

        [TestMethod]
        public void testCantAddWrongAnimal()
        {
            bigcat.AddAnimal(clownfish);
            Assert.AreEqual(0, bigcat.getNumberOfAnimals());
        }
    }
}