using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class GreatswordTest
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
        public void GreatSwordAttackDamage()
        {
            Greatsword greatsword = new Greatsword();
            Assert.AreEqual(greatsword.Attack, 45);
        }
    }
}