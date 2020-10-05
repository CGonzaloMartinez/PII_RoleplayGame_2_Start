using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class BowTest
    {
        private Bow bow;

        [SetUp]
        public void Setup()
        {
            this.bow = new Bow();        
        }
        [Test]
        /*
            Es necesario probar asignar un valor válido, para asegurar que 
            no está fallando la implementación del setter del Atributo.
        */
        public void BowGetAttack()
        {
            Assert.AreEqual(15, bow.Attack);
        }
    }
}