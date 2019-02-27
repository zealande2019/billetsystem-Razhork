using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BilUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BilTestMethod()
        {
            
                //Arrange
                var bil = new Bil();

                //Act
                decimal pris = bil.Pris();

                //Assert
                Assert.AreEqual(240,pris);
        }

        [TestMethod]

        public void McTestMethod()
        {
            //Arrange
            var mc = new MC();

            //Act
            decimal pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, pris);
        }
    }
}
