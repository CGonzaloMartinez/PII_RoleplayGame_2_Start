using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class KnightTest
    {
        private Knight knight;

        [SetUp]
        public void Setup()
        {
            knight = new Knight("Arturo");
            Greatsword gsword = new Greatsword();
            knight.Greatsword = gsword;
            HeavyArmor hArmor = new HeavyArmor();
            knight.HeavyArmor = hArmor;
            Helmet helmet = new Helmet();
            knight.Helmet = helmet;
            
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignEmptyName()
        {
            this.knight.Name = "";
            Assert.AreEqual(this.knight.Name, "Arturo");
        }
        [Test]
        /*
            Es necesario probar asignar un valor inválido, para asegurar que 
            no está fallando la validación del setter del Atributo.
        */
        public void AssignNegativeHealth()
        {
            this.knight.Health = -20;
            Assert.AreEqual(this.knight.Health, 0);
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewName()
        {
            this.knight.Name = "not Arturo";
            Assert.AreEqual(this.knight.Name, "not Arturo");
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void AssignNewHealth()
        {
            this.knight.Health = 150;
            Assert.AreEqual(this.knight.Health, 150);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeGreatsword
            efectivamente cambie el arco por uno nuevo, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeGreatsword()
        {
            Greatsword newGreatsword = new Greatsword();
            this.knight.Greatsword = newGreatsword;
            Assert.AreEqual(this.knight.Greatsword, newGreatsword);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveGreatsword
            efectivamente elimine el arco del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveGreatsword()
        {
            this.knight.Greatsword = null;
            Assert.AreEqual(this.knight.Greatsword, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeHelmet
            efectivamente cambie la armadura por una nueva, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeHelmet()
        {
            Helmet newHelmet = new Helmet();
            this.knight.Helmet = newHelmet;
            Assert.AreEqual(this.knight.Helmet, newHelmet);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveHelmet
            efectivamente elimine la armadura del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveHelmet()
        {
            this.knight.Helmet = null;
            Assert.AreEqual(this.knight.Helmet, null);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método ChangeHeavyArmor
            efectivamente cambie la armadura por una nueva, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void ChangeHeavyArmor()
        {
            HeavyArmor newHeavyArmor = new HeavyArmor();
            this.knight.HeavyArmor = newHeavyArmor;
            Assert.AreEqual(this.knight.HeavyArmor, newHeavyArmor);
        }
        [Test]
        /*
            Es necesario probar que la implementación del método RemoveHeavyArmor
            efectivamente elimine la armadura del personaje, ya que esta es la finalidad
            del mismo. Si se cambiara la implementación y este test fallara, entonces
            estaría mal implementado el método.
        */
        public void RemoveHeavyArmor()
        {
            this.knight.HeavyArmor = null;
            Assert.AreEqual(this.knight.HeavyArmor, null);
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
            this.knight.Health = 50;
            this.knight.Cure();
            Assert.AreEqual(this.knight.Health, 100);
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
            Assert.AreEqual(this.knight.Greatsword.Attack, this.knight.Attack);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura suficiente
            para aguantar el daño recibido se pierde la cantidad justa y no se
            pierde vida.
        */
        public void TakeDamageArmorAbsorbsIt()
        {
            this.knight.ReceiveAttack(32);
            Assert.AreEqual(this.knight.Health, 100);
        }
        [Test]
        /*
            Este test asegura que si el personaje tiene armadura y vida 
            pero recibe un daño mayor a la suma de ambos, entonces ambos
            valores quedan en 0.
        */
        public void TakeDamageMoreThanAvailableLife()
        {
            this.knight.ReceiveAttack(300);
            Assert.AreEqual(this.knight.Health, 0);
        }
    }
}