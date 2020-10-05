using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTest
    {
        private Archer archer;

        [SetUp]
        public void Setup()
        {
            this.archer = new Archer("Legolas");
            Bow bow = new Bow();
            this.archer.Bow = bow;
            Armor armor = new Armor();
            this.archer.Armor = armor;
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignEmptyName()
        {
            this.archer.Name = "";
            Assert.AreEqual(this.archer.Name, "Legolas");
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeHealth()
        {
            this.archer.Health = -20;
            Assert.AreEqual(this.archer.Health, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewName()
        {
            this.archer.Name = "Not Legolas";
            Assert.AreEqual(this.archer.Name, "Not Legolas");
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewHealth()
        {
            this.archer.Health = 150;
            Assert.AreEqual(this.archer.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeBow
            efectivamente cambie el arco por uno nuevo, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeBow()
        {
            Bow newBow = new Bow();
            this.archer.Bow = newBow;
            Assert.AreEqual(this.archer.Bow, newBow);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveBow
            efectivamente elimine el arco del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveBow()
        {
            this.archer.Bow = null;
            Assert.AreEqual(this.archer.Bow, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeArmor
            efectivamente cambie la armadura por una nueva, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeArmor()
        {
            Armor newArmor = new Armor();
            this.archer.Armor = newArmor;
            Assert.AreEqual(this.archer.Armor, newArmor);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveArmor
            efectivamente elimine la armadura del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveArmor()
        {
            this.archer.Armor = null;
            Assert.AreEqual(this.archer.Armor, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método Heal
            efectivamente lleve al personaje de vuelta a la vida máxima.
            Si se hicieran cambios en Heal o en los valores de vida del personaje,
            y este test fallara entonces estaría mal la implementación del metodo Heal.
        */
        public void HealCharacterToFullLife()
        {
            this.archer.Health = 50;
            this.archer.Cure();
            Assert.AreEqual(this.archer.Health, 100);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método GetAttack
            efectivamente devuelva el total de ataque del personaje, en caso
            de que se agregaran mas items o se cambiara la implementación, y este 
            test fallara entonces estaría mal implementado GetAttack.
        */
        public void GetCharacterAttack()
        {
            Assert.AreEqual(this.archer.Bow.Attack, this.archer.Attack);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura suficiente
            para aguantar el daño recibido se pierde la cantidad justa y no se
            pierde vida.
        */
        public void TakeDamageArmorAbsorbsIt()
        {
            this.archer.ReceiveAttack(25);
            Assert.AreEqual(this.archer.Health, 100);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanAvailableLife()
        {
            this.archer.ReceiveAttack(200);
            Assert.AreEqual(this.archer.Health, 0);
        }
    }

}