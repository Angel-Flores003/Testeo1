using activitiesUtils;
namespace Testeo1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateRange0()//extremo inferiror del rango
        {
            //Arrange 
            //Act
            //Assert
            Assert.IsTrue(Utils.IsValidAge(0));
        }
        [TestMethod]
        public void ValidateRang120()//extremo superior del rango
        {
            //Arrange 
            //Act
            //Assert
            Assert.IsTrue(Utils.IsValidAge(120));
        }
        [TestMethod]
        public void ValidateRange60()//numero dentro del rango
        {
            //Arrange 
            //Act
            //Assert
            Assert.IsTrue(Utils.IsValidAge(60));
        }
        [TestMethod]
        public void NotValidateRange1()//-1 fuera de rango
        {
            //Arrange 
            //Act
            //Assert
            Assert.IsFalse(Utils.IsValidAge(-1));
        }
        [TestMethod]
        public void NotValidateRange2()//121 fuera de rango
        {
            //Arrange 
            //Act
            //Assert
            Assert.IsFalse(Utils.IsValidAge(121));
        }
        [TestMethod]
        public void AppliedDiscount()//121 fuera de rango
        {
            //Arrange 
            int a;
            //Act
            //Assert
            a = Assert.IsFalse(Utils.AppliedDiscount(12));
        }
    }
}