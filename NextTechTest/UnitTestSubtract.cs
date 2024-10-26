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
            int numOne = 5;
            int numTwo = 3;
            int expectedDifference = 2;

            // Act
            int result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the expected difference.");
        }

        [TestMethod]
        public void Test_SubtractMethod_WithNegativeNumbers()
        {
            // Arrange
            var calculator = new Calc();
            int numOne = -5;
            int numTwo = -3;
            int expectedDifference = -2;

            // Act
            int result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum for negative numbers.");
        }
        
        [TestMethod]
        public void Test_SubtractMethod_WithZero()
        {
            // Arrange
            var calculator = new Calc();
            int numOne = 0;
            int numTwo = 7;
            int expectedDifference = -7;

            // Act
            int result = calculator.subtract(numOne, numTwo);

            // Assert
            Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum when adding zero.");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Test_SubtractMethod_WithDecimal()
        {
            // Arrange
            var calculator = new Calc();
            double numOne = 0.0;
            double numTwo = 7.0;
            int expectedDifference = -7;

            // Act & Assert
            int result = calculator.subtract((int)numOne, (int)numTwo);

             Assert.AreEqual(expectedDifference, result, "The add method did not return the correct sum when adding with double.");
        }
    }
}
