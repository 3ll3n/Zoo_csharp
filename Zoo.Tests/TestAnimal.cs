using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Animals;
using Zoo.Entities.Foods;

namespace Zoo.Tests
{
    [TestClass]
    public class TestAnimal
    {
        Tiger tiger;
        ClownFish clownfish;
        Parrot parrot;

        [TestInitialize]
        public void Init()
        {
            tiger = new Tiger("Tony", 8);
            clownfish = new ClownFish("Nemo", 2);
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void TestGetName()
        {
            Assert.AreEqual("Tony", tiger.GetName());
        }

        [TestMethod]
        public void TestCanSetName()
        {
            tiger.SetName("Khan");
            Assert.AreEqual("Khan", tiger.GetName());
        }

        [TestMethod]
        public void TestGetAge()
        {
            Assert.AreEqual(8, tiger.GetAge());
        }

        [TestMethod]
        public void TestSetAge()
        {
            tiger.SetAge(5);
            Assert.AreEqual(5, tiger.GetAge());
        }

        [TestMethod]
        public void TestBreathe()
        {
            Assert.AreEqual("I can breathe", tiger.Breathe());
        }


        [TestMethod]
        public void TestBellyEmpty()
        {
            Assert.AreEqual(0, tiger.FoodCount());
        }

        [TestMethod]
        public void TestPoop()
        {
            Seeds seeds = new Seeds();
            parrot.Eat(seeds);
            parrot.Poop();
            Assert.AreEqual(parrot.FoodCount(), 0);
        }
    }
}