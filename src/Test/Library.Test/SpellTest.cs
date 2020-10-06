using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class SpellTest
    {

        private Spell spell;

        [SetUp]
        public void Setup()
        {
            spell = new Spell();
        }

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void SpellCorrectAttack()
        {
            Assert.AreEqual(70, this.spell.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void SpellCorrectDefense()
        {
            Spell Spell = new Spell();
            Assert.AreEqual(70, this.spell.Defense);
        }

    }
}