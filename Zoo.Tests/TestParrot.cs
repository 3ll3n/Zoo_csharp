using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Foods;

namespace Zoo.Tests
{
    [TestClass]
    public class TestParrot
    {
        Parrot parrot;

        [TestInitialize]
        public void Init()
        {
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void TestFly()
        {
            Assert.AreEqual("I can fly!", parrot.Fly());
        }

        [TestMethod]
        public void testTalk()
        {
            Assert.AreEqual("I can talk!", parrot.Talk());
        }

        [TestMethod]
        public void TestCanEatSeeds()
        {
            Seeds seeds = new Seeds();
            parrot.Eat(seeds);
            Assert.AreEqual(1, parrot.FoodCount());
        }

        [TestMethod]
        public void TestCantEatAlgae()
        {
            Algae algae = new Algae();
            parrot.Eat(algae);
            Assert.AreEqual(0, parrot.FoodCount());
        }
    }
}