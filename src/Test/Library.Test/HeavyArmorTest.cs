using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class HeavyArmorTest
    {
        private HeavyArmor heavyArmor;

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        /*
            Se le asigna un valor para checkear que la implementacion
            del setter no este fallando.
        */
        public void HeavyArmorDefense()
        {
            HeavyArmor heavyArmor = new HeavyArmor();
            Assert.AreEqual(heavyArmor.Defense, 40);
        }
    }
}