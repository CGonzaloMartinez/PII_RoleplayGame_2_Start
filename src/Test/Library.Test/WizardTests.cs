using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
     public class WizardTests
    {
        string expectedName = "Merlin";
        int expectedHealth = 100;
        int expectedInorrectHealth = 0;

        Wizard testingWizard = new Wizard("Merlin");
        

        [Test]    


        /*
            Es necesario validar que el nombre que se está asignando sea de manera correcta, 
            para verificar el correcto funcionamiento del setter.
        */   
        public void WizardCorrectName()
        {
            testingWizard.Name = "";
            testingWizard.Name = "Merlin";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test]   

        /*
            Con este Test se está verificando que la validación de la asignación de nombre sea la esperada;
            en caso de que se intente asignar un string vacío como astributo name al objeto, este último mantendrá
            su name anterior.
        */ 

        public void WizardInorrectName()
        {
            Wizard testingWizard = new Wizard("Merlin");
            testingWizard.Name = "";
            Assert.AreEqual(expectedName, testingWizard.Name);   
        }

        [Test] 

         /*
            Es necesario validar que al instanciarse un objeto de la clase Wizard, su atributo "Health" sea igual a 100,
            que es la vida que poseen los Wizards de este mundo creado.
        */ 
           public void WizardCorrectHealth()
        {
            Wizard testingWizard = new Wizard("Merlin");
            Assert.AreEqual(expectedHealth, testingWizard.Health);   
        }

        [Test]  

        /*
            Es necesario verificar que la validación de la asignación de la vida de un mago sea la correcta;
            en caso de que se intente asignar un entero menor a 0 a la Health de un objeto de la clase Wizard, este será cambiado a cero.
        */ 
           public void WizardInorrectHealth()
        {
            testingWizard.Health = -1;
            Assert.AreEqual(expectedInorrectHealth, testingWizard.Health);   
        }


        [Test]

        /*
        Es necesario validar que el método Heal implementado, recupere la vida inicial del mago.
        */
        public void TestingCure()
        {
            testingWizard.Health = 10;
            testingWizard.Cure();
            Assert.AreEqual(expectedHealth, testingWizard.Health);
        }

        [Test]

        /*
        Es necesario validar que el método GetWizardAttack implementado, asigne como ataque del personaje
        la suma del ataque de su FireSpear, de su MagicWand, y del Spell de su Spellbook.
        */
        public void TestingWizardAttack()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            testingWizard.spellsBook = book;

            testingWizard.staff = new Staff();

            int expectedAttack = 170;
            Assert.AreEqual(expectedAttack, testingWizard.Attack);
        }

        [Test]

        /*
            Es importante validar que el daño que recibe un mago sea el adecuado. Esto es, que se priorice en primera intancia
            la disminución completa de su escudo (suma de las Defenses que sus items le proveen), y posteriormente su Health.

        */

        public void TestingReceiveAttack()
        {  

            Staff magicStaff = new Staff();
            testingWizard.staff = magicStaff;

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            testingWizard.spellsBook = book;

            int expectedLife = 100;
            testingWizard.ReceiveAttack(90);
            Assert.AreEqual(expectedLife, testingWizard.Health);
        }


        [Test]

     
        public void TestingRemoveStaff()
        {
            Staff magicStaff = new Staff();
            testingWizard.staff = magicStaff;
            testingWizard.staff = null;
            Assert.AreEqual(testingWizard.staff,null);
        }


        
        public void TestingChangeStaff()
        {
            Staff magicStaff = new Staff();
            testingWizard.staff = magicStaff;

            Staff magicStaff2 = new Staff();
            testingWizard.staff = magicStaff2;
          
            Assert.AreEqual(testingWizard.staff, magicStaff2);
        }

        [Test]

        public void TestingRemoveSpellsBook()
        {
            SpellsBook magicBook = new SpellsBook();
            testingWizard.spellsBook = magicBook;
            testingWizard.spellsBook = null;
            Assert.AreEqual(testingWizard.spellsBook,null);
        }
        
           [Test]

        public void TestingChangeSpellsBook()
        {
            SpellsBook magicBook = new SpellsBook();
            testingWizard.spellsBook = magicBook;

            SpellsBook magicBook2 = new SpellsBook();
            testingWizard.spellsBook = magicBook2;
          
            Assert.AreEqual(testingWizard.spellsBook,magicBook2);
        }



    }
}