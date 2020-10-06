using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class SpellsBookTest
    {

        private SpellsBook spellsBook;

        [SetUp]
        public void Setup()
        {
            spellsBook = new SpellsBook();
            this.spellsBook.Spells = new Spell[]{ new Spell(), new Spell() };
        }
        

        [Test]

        /*
            Es necesario testear que la implementación del atributo Attack esté funcionando correctamente. 
        */
        public void SpellsBookCorrectAttackTest()
        {
            Assert.AreEqual(140, this.spellsBook.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void SpellsBookCorrectDefense()
        {
            Assert.AreEqual(140, this.spellsBook.Defense);
        }

    }
}

