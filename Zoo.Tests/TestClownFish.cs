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
        public void Init()
        {
            clownfish = new ClownFish("Nemo", 2);
        }

        [TestMethod]
        public void TestSwim()
        {
            Assert.AreEqual("I live in the water and love to swim!", clownfish.Swim());
        }

        [TestMethod]
        public void TestBreathe()
        {
            Assert.AreEqual("I can breathe under water!", clownfish.Breathe());
        }

        [TestMethod]
        public void TestBlowBubbles()
        {
            Assert.AreEqual("I can blow bubbles!", clownfish.BlowBubbles());
        }

        [TestMethod]
        public void TestCanEatAlgae()
        {
            Algae algae = new Algae();
            clownfish.Eat(algae);
            Assert.AreEqual(1, clownfish.FoodCount());
        }

        [TestMethod]
        public void TestCantEatSteak()
        {
            Steak steak = new Steak();
            clownfish.Eat(steak);
            Assert.AreEqual(0, clownfish.FoodCount());
        }
    }
}