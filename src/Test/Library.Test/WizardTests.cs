using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
     public class WizardTests
    {

        private Wizard testingWizard;

        [SetUp]
        public void Setup()
        {
            this.testingWizard = new Wizard("Merlin");
            Staff Staff = new Staff();
            this.testingWizard.Staff = Staff;

            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(), new Spell() };
            this.testingWizard.SpellsBook = book;
        }
        

        [Test]    


        /*
            Es necesario validar que el nombre que se está asignando sea de manera correcta, 
            para verificar el correcto funcionamiento del setter.
        */   
        public void WizardCorrectName()
        {
            this.testingWizard.Name = "Harry Potter";

            string expectedName = "Harry Potter";
            Assert.AreEqual(expectedName, this.testingWizard.Name);   
        }

        [Test]   

        /*
            Con este Test se está verificando que la validación de la asignación de nombre sea la esperada;
            en caso de que se intente asignar un string vacío como astributo name al objeto, este último mantendrá
            su name anterior.
        */ 

        public void WizardInorrectName()
        {
            this.testingWizard.Name = "";

            string expectedName = "Merlin";
            Assert.AreEqual(expectedName, this.testingWizard.Name);   
        }

        [Test] 

         /*
            Es necesario validar que al instanciarse un objeto de la clase Wizard, su atributo "Health" sea igual a 100,
            que es la vida que poseen los Wizards de este mundo creado.
        */ 
           public void WizardCorrectHealth()
        {
            int expectedHealth = 100;
            Assert.AreEqual(expectedHealth, this.testingWizard.Health);   
        }

        [Test]  

        /*
            Es necesario verificar que la validación de la asignación de la vida de un mago sea la correcta;
            en caso de que se intente asignar un entero menor a 0 a la Health de un objeto de la clase Wizard, este será cambiado a cero.
        */ 
           public void WizardInorrectHealth()
        {
            this.testingWizard.Health = -1;

            int expectedInorrectHealth = 0;
            Assert.AreEqual(expectedInorrectHealth, this.testingWizard.Health);   
        }


        [Test]

        /*
        Es necesario validar que el método Heal implementado, recupere la vida inicial del mago.
        */
        public void TestingCure()
        {
            this.testingWizard.Health = 10;
            this.testingWizard.Cure();

            int expectedHealth = 100;
            Assert.AreEqual(expectedHealth, this.testingWizard.Health);
        }

        [Test]

        /*
        Es necesario validar que el método GetWizardAttack implementado, asigne como ataque del personaje
        la suma del ataque de su FireSpear, de su MagicWand, y del Spell de su Spellbook.
        */
        public void TestingWizardAttack()
        {
            
            //int expectedAttack = this.testingWizard.Staff.Attack + this.testingWizard.SpellsBook.Attack;
            Assert.AreEqual(this.testingWizard.SpellsBook.Attack + this.testingWizard.Staff.Attack, this.testingWizard.Attack);
        }

        [Test]

        /*
            Es importante validar que el daño que recibe un mago sea el adecuado. Esto es, que se priorice en primera intancia
            la disminución completa de su escudo (suma de las Defenses que sus items le proveen), y posteriormente su Health.

        */

        public void TestingReceiveAttackWithoutChangesInHealth()
        {  
            testingWizard.ReceiveAttack(90);
            Assert.AreEqual(100, testingWizard.Health);
        }

        public void TestingReceiveAttackWithChangesInHealth()
        {  
            testingWizard.ReceiveAttack(testingWizard.SpellsBook.Defense + testingWizard.Staff.Defense + 10);
            Assert.AreEqual(90, testingWizard.Health);
        }


        [Test]

     
        public void TestingRemoveStaff()
        {
            this.testingWizard.Staff = null;
            Assert.AreEqual(this.testingWizard.Staff,null);
        }


        
        public void TestingChangeStaff()
        {
            Staff magicStaff2 = new Staff();
            this.testingWizard.Staff = magicStaff2;
          
            Assert.AreEqual(this.testingWizard.Staff, magicStaff2);
        }

        [Test]

        public void TestingRemoveSpellsBook()
        {
            this.testingWizard.SpellsBook = null;
            Assert.AreEqual(this.testingWizard.SpellsBook,null);
        }
        
           [Test]

        public void TestingChangeSpellsBook()
        {
 
            SpellsBook magicBook2 = new SpellsBook();
            this.testingWizard.SpellsBook = magicBook2;
          
            Assert.AreEqual(this.testingWizard.SpellsBook,magicBook2);
        }



    }
}