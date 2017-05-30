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
        public void before()
        {
            tiger = new Tiger("Tony", 8);
        }

        [TestMethod]
        public void testRoar()
        {
            Assert.AreEqual("Roooaaar", tiger.roar());
        }

        [TestMethod]
        public void testHunt()
        {
            Assert.AreEqual("I am a hunter", tiger.hunt());
        }

        [TestMethod]
        public void testCanEatSteak()
        {
            Steak steak = new Steak();
            tiger.eat(steak);
            Assert.AreEqual(1, tiger.foodCount());
        }

        [TestMethod]
        public void testCantEatSeeds()
        {
            Seeds seeds = new Seeds();
            tiger.eat(seeds);
            Assert.AreEqual(0, tiger.foodCount());
        }
    }
}