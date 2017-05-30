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
        public void before()
        {
            tiger = new Tiger("Tony", 8);
            clownfish = new ClownFish("Nemo", 2);
            parrot = new Parrot("Polymorphism", 20);
        }

        [TestMethod]
        public void testGetName()
        {
            Assert.AreEqual("Tony", tiger.getName());
        }

        [TestMethod]
        public void testCanSetName()
        {
            tiger.setName("Khan");
            Assert.AreEqual("Khan", tiger.getName());
        }

        [TestMethod]
        public void testGetAge()
        {
            Assert.AreEqual(8, tiger.getAge());
        }

        [TestMethod]
        public void testSetAge()
        {
            tiger.setAge(5);
            Assert.AreEqual(5, tiger.getAge());
        }

        [TestMethod]
        public void testBreathe()
        {
            Assert.AreEqual("I can breathe", tiger.breathe());
        }


        [TestMethod]
        public void testBellyEmpty()
        {
            Assert.AreEqual(0, tiger.foodCount());
        }

        [TestMethod]
        public void testPoop()
        {
            Seeds seeds = new Seeds();
            parrot.eat(seeds);
            parrot.poop();
            Assert.AreEqual(parrot.foodCount(), 0);
        }
    }
}