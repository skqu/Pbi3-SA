// Calculator.cs
namespace SimpleCalculatorApp
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, string operation)
        {
            return operation switch
            {
                "+" => Add(num1, num2),
                "-" => Subtract(num1, num2),
                "*" => Multiply(num1, num2),
                "/" => Divide(num1, num2),
                _ => throw new ArgumentException("Invalid operator", nameof(operation))
            };
        }

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }

    public class Program
    {
        static void Main()
        {
            var calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("\nSimple Calculator");
                Console.WriteLine("----------------");
                
                // Get first number
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                
                // Get operator
                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();
                if (!new[] { "+", "-", "*", "/" }.Contains(op))
                {
                    Console.WriteLine("Invalid operator. Please use +, -, *, or /");
                    continue;
                }
                
                // Get second number
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                try
                {
                    var result = calculator.Calculate(num1, num2, op);
                    Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                
                // Ask if user wants to continue
                Console.Write("\nPerform another calculation? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
                
                Console.Clear();
            }
        }
    }
}