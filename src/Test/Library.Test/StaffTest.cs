using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class StaffTest
    {
        private Staff staff;

        [SetUp]
        public void Setup()
        {
            staff = new Staff();
        }

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void StaffCorrectAttack()
        {
            Assert.AreEqual(100, staff.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void StaffCorrectDefense()
        {
            Assert.AreEqual(100, staff.Defense);
        }

    }
}