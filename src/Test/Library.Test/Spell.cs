using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class SpellTest
    {
        int expectedAttack = 70;
        int expectedDefense = 70;

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void SpellCorrectAttack()
        {
            Spell Spell = new Spell();
            Assert.AreEqual(expectedAttack, Spell.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void SpellCorrectDefense()
        {
            Spell Spell = new Spell();
            Assert.AreEqual(expectedDefense, Spell.Defense);
        }

    }
}