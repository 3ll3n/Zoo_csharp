using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Entities.Enclosures;

namespace Zoo.Tests
{
    [TestClass]
    public class TestZoo
    {
        Zoo.Entities.Zoo zoo;
        Enclosure enclosure1;
        Enclosure enclosure2;

        [TestInitialize]
        public void Init()
        {
            zoo = new Zoo.Entities.Zoo("Animal Sanctuary");
            enclosure1 = new BigCat("Big Cats");
            enclosure2 = new Aviary("Aviary");
        }

        [TestMethod]
        public void TestAddEnclosure()
        {
            zoo.AddEnclosure(enclosure1);
            Assert.AreEqual(1, zoo.GetNumberOfEnclosures());
        }

        [TestMethod]
        public void TestNumberOfEnclosures()
        {
            zoo.AddEnclosure(enclosure1);
            zoo.AddEnclosure(enclosure2);
            Assert.AreEqual(2, zoo.GetNumberOfEnclosures());
        }
    }
}