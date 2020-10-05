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
            Dwarf dwarf = new Dwarf("Pitufo");
            Axe axe = new Axe();
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido y no este fallando.
        */
        public void AssignEmptyName()
        {
            this.dwarf.Name = "";
            Assert.AreEqual(this.dwarf.Name, "Pitufo");
        }
        [Test]
        /*
            Se le asigna un valor invalido para checkear que la implementacion
            del setter siempre de un valor valido y no este fallando.
        */
        public void AssignNegativeHealth()
        {
            this.dwarf.Health = -35;
            Assert.AreEqual(this.dwarf.Health, 0);
        }
        [Test]
        /*
            Se le asigna un valor valido para checkear que la
            implementacion del setter no este fallando.
        */
        public void AssignNewName()
        {
            this.dwarf.Name = "Something Else";
            Assert.AreEqual(this.dwarf.Name, "Something Else");
        }
        [Test]
        /*
            Se le asigna un valor valido para checkear que la
            implementacion del setter no este fallando.
        */
        public void AssignNewHealth()
        {
            this.dwarf.Health = 150;
            Assert.AreEqual(this.dwarf.Health, 150);
        }

        
        [Test]
        /*
            Es necesario probar que la implementación del método Heal
            efectivamente lleve al personaje de vuelta a la vida máxima.
            Si se hicieran cambios en Heal o en los valores de vida del personaje,
            y este test fallara entonces estaría mal la implementación del metodo Heal.
        */
        public void HealCharacterToMaxHealthPoints()
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
            this.dwarf.ReceiveAttack(25);
            Assert.AreEqual(this.dwarf.Defense, 7);
            Assert.AreEqual(this.dwarf.Health, 100);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanArmorPlusHealthPoints()
        {
            this.dwarf.ReceiveAttack(132);
            Assert.AreEqual(this.dwarf.Defense, 0);
            Assert.AreEqual(this.dwarf.Health, 0);
        }
    }
}