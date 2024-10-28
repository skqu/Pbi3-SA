using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextTechTest
{
    [TestClass]
    public class UnitTestSubtract
    {
        [TestMethod]
        public void Test_SubtractMethod_ReturnsCorrectDifference()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 5;
            double numTwo = 3;
            double expectedDifference = 2;

            // Act
            double result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the expected difference.");
        }

        [TestMethod]
        public void Test_SubtractMethod_WithNegativeNumbers()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = -5;
            double numTwo = -3;
            double expectedDifference = -2;

            // Act
            double result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum for negative numbers.");
        }
        
        [TestMethod]
        public void Test_SubtractMethod_WithZero()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 0;
            double numTwo = 7;
            double expectedDifference = -7;

            // Act
            double result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum when adding zero.");
        }

        [TestMethod]
        public void Test_SubtractMethod_WithDecimal()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 0.0;
            double numTwo = 7.0;
            double expectedDifference = -7;

            // Act & Assert
            double result = calculator.subtract(numOne, numTwo);

             Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum when adding with double.");
        }
    }
}
