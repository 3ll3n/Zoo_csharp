using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Foods;

namespace Zoo.Tests
{
    [TestClass]
    public class TestTiger
    {
        Tiger tiger;

        [TestInitialize]
        public void Init()
        {
            tiger = new Tiger("Tony", 8);
        }

        [TestMethod]
        public void TestRoar()
        {
            Assert.AreEqual("Roooaaar", tiger.Roar());
        }

        [TestMethod]
        public void TestHunt()
        {
            Assert.AreEqual("I am a hunter", tiger.Hunt());
        }

        [TestMethod]
        public void TestCanEatSteak()
        {
            Steak steak = new Steak();
            tiger.Eat(steak);
            Assert.AreEqual(1, tiger.FoodCount());
        }

        [TestMethod]
        public void TestCantEatSeeds()
        {
            Seeds seeds = new Seeds();
            tiger.Eat(seeds);
            Assert.AreEqual(0, tiger.FoodCount());
        }
    }
}