using SimpleCalculatorApp;
using Xunit;

namespace SimpleCalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(-1, 2, 1)]
    [InlineData(3, 3, 6)]

    public void Add(double a, double b, double expected)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(13, 5, 8)]
    [InlineData(-6, 3, -9)]

    public void Subtract(double a, double b, double expected)
    {
        var result = _calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(13, 5, 65)]
    [InlineData(-6, 3, -18)]
    [InlineData(0, 3, 0)]

    public void Multiply(double a, double b, double expected)
    {
        var result = _calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(13, 5, 2.6)]
    [InlineData(-6, 3, -2)]
    [InlineData(0, 3, 0)]
    [InlineData(12, 3, 4)]

    public void Divide(double a, double b, double expected)
    {
        var result = _calculator.Divide(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("+", 1, 1, 2)]
    [InlineData("-", -1, 2, -3)]
    [InlineData("*", 3, 3, 9)]
    [InlineData("/", 10, 2, 5)]

    public void Calculate(string operation, double a, double b, double expected)
    {
        var result = _calculator.Calculate(a, b, operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculate_InvalidOperator_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _calculator.Calculate(1, 1, "invalid"));
    }
}