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
        public void before()
        {
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void testFly()
        {
            Assert.AreEqual("I can fly!", parrot.fly());
        }

        [TestMethod]
        public void testTalk()
        {
            Assert.AreEqual("I can talk!", parrot.talk());
        }

        [TestMethod]
        public void testCanEatSeeds()
        {
            Seeds seeds = new Seeds();
            parrot.eat(seeds);
            Assert.AreEqual(1, parrot.foodCount());
        }

        [TestMethod]
        public void testCantEatAlgae()
        {
            Algae algae = new Algae();
            parrot.eat(algae);
            Assert.AreEqual(0, parrot.foodCount());
        }
    }
}