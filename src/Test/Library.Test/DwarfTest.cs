using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTest
    {
        private Dwarf dwarf;

        [SetUp]
        public void Setup()
        {
            dwarf = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            dwarf.Axe = axe;
            dwarf.Helmet = helmet;
            dwarf.Shield = shield;
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignEmptyName()
        {
            this.dwarf.Name = "";
            Assert.AreEqual(this.dwarf.Name, "Gimli");
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeHealth()
        {
            this.dwarf.Health = -20;
            Assert.AreEqual(this.dwarf.Health, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewName()
        {
            this.dwarf.Name = "Not Gimli";
            Assert.AreEqual(this.dwarf.Name, "Not Gimli");
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewHealth()
        {
            this.dwarf.Health = 150;
            Assert.AreEqual(this.dwarf.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeBow
            efectivamente cambie el arco por uno nuevo, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeAxe()
        {
            Axe newAxe = new Axe();
            this.dwarf.Axe = newAxe;
            Assert.AreEqual(this.dwarf.Axe, newAxe);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveBow
            efectivamente elimine el arco del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveAxe()
        {
            this.dwarf.Axe = null;
            Assert.AreEqual(this.dwarf.Axe, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeArmor
            efectivamente cambie la armadura por una nueva, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeHelmet()
        {
            Helmet newHelmet = new Helmet();
            this.dwarf.Helmet = newHelmet;
            Assert.AreEqual(this.dwarf.Helmet, newHelmet);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveArmor
            efectivamente elimine la armadura del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveHelmet()
        {
            this.dwarf.Helmet = null;
            Assert.AreEqual(this.dwarf.Helmet, null);
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
            this.dwarf.Health = 50;
            this.dwarf.Cure();
            Assert.AreEqual(this.dwarf.Health, 100);
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
            Assert.AreEqual(this.dwarf.Axe.Attack, this.dwarf.Attack);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura suficiente
            para aguantar el daño recibido se pierde la cantidad justa y no se
            pierde vida.
        */
        public void TakeDamageArmorAbsorbsIt()
        {
            this.dwarf.ReceiveAttack(32);
            Assert.AreEqual(this.dwarf.Health, 100);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanAvailableLife()
        {
            this.dwarf.ReceiveAttack(200);
            Assert.AreEqual(this.dwarf.Health, 0);
        }
    }
}