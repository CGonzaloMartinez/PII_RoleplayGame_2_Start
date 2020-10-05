using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


     public class StaffTest
    {
        int expectedAttack = 100;
        int expectedDefense = 100;

        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Attack esté funcionando correctamente. 
        */
        public void StaffCorrectAttack()
        {
            Staff staff = new Staff();
            Assert.AreEqual(expectedAttack, staff.Attack);
        }


        [Test]

        /*
            Es necesario testear que la implementación del setter del atributo Defense esté funcionando correctamente. 
        */
        public void StaffCorrectDefense()
        {
            Staff staff = new Staff();
            Assert.AreEqual(expectedDefense, staff.Defense);
        }

    }
}