using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ShieldTest
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
        public void ShieldDefense()
        {
            Shield shield = new Shield();
            Assert.AreEqual(shield.Defense, 14);
        }
    }
}