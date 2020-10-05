using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class SpellsBookTest
    {

        int expectedAttack = 140;

        int expectedDefense = 140;

        [Test]

        /*
            Es necesario testear que la implementación del atributo Attack esté funcionando correctamente. 
        */
        public void SpellsBookCorrectAttackTest()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(), new Spell() };

            Assert.AreEqual(expectedAttack, book.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void SpellsBookCorrectDefense()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(),new Spell() };

            Assert.AreEqual(expectedDefense, book.Defense);
        }

    }
}

