using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class HelmetTest
    {

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        /*
            Se le asigna un valor para checkear que la implementacion
            del setter no este fallando.
        */
        public void HelmetDefense()
        {
            Helmet helmet = new Helmet();
            Assert.AreEqual(helmet.Defense, 18);
        }
    }
}