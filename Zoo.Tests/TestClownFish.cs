using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Foods;

namespace Zoo.Tests
{
    [TestClass]
    public class TestClownFish
    {
        ClownFish clownfish;

        [TestInitialize]
        public void before()
        {
            clownfish = new ClownFish("Nemo", 2);
        }

        [TestMethod]
        public void testSwim()
        {
            Assert.AreEqual("I live in the water and love to swim!", clownfish.swim());
        }

        [TestMethod]
        public void testBreathe()
        {
            Assert.AreEqual("I can breathe under water!", clownfish.breathe());
        }

        [TestMethod]
        public void testBlowBubbles()
        {
            Assert.AreEqual("I can blow bubbles!", clownfish.blowBubbles());
        }

        [TestMethod]
        public void testCanEatAlgae()
        {
            Algae algae = new Algae();
            clownfish.eat(algae);
            Assert.AreEqual(1, clownfish.foodCount());
        }

        [TestMethod]
        public void testCantEatSteak()
        {
            Steak steak = new Steak();
            clownfish.eat(steak);
            Assert.AreEqual(0, clownfish.foodCount());
        }
    }
}