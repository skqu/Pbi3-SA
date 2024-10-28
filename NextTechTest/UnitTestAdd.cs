using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextTechTest
{
    [TestClass]
    public class UnitTestAdd
    {
        [TestMethod]
        public void Test_AddMethod_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 5;
            double numTwo = 3;
            double expectedSum = 8;

            // Act
            double result = calculator.add(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedSum, result, "The add method did not return the expected sum.");
        }

        [TestMethod]
        public void Test_AddMethod_WithNegativeNumbers()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = -5;
            double numTwo = -3;
            double expectedSum = -8;

            // Act
            double result = calculator.add(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedSum, result, "The add method did not return the correct sum for negative numbers.");
        }
        
        [TestMethod]
        public void Test_AddMethod_WithZero()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 0;
            double numTwo = 7;
            double expectedSum = 7;

            // Act
            double result = calculator.add(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedSum, result, "The add method did not return the correct sum when adding zero.");
        }

        [TestMethod]
        public void Test_AddMethod_WithDecimal()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 0.0;
            double numTwo = 7.0;
            double expectedSum = 7;

            // Act & Assert
            double result = calculator.add(numOne, numTwo);

             Assert.AreEqual(expectedSum, result, "The add method did not return the correct sum when adding with double.");
        }
    }
}
