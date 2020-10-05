using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class AxeTest
    {
        private Axe axe;

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        /*
            Se le asigna un valor para checkear que la implementacion
            del setter no este fallando.
        */
        public void AxeAttackDamage()
        {
            Axe axe = new Axe();
            Assert.AreEqual(axe.Attack, 25);
        }
    }
}