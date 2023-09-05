
namespace DelegateDemo
{
    public delegate double ArithmeticOperation(double operand1, double operand2);

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            ArithmeticOperation addition = (a, b) => a + b;
            ArithmeticOperation subtraction = (a, b) => a - b;
            ArithmeticOperation multiplication = (a, b) => a * b;
            ArithmeticOperation division = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero.");
                    return double.NaN;
                }
                return a / b;
            };

            double result1 = calculator.Calculate(10, 5, addition);
            double result2 = calculator.Calculate(10, 5, subtraction);
            double result3 = calculator.Calculate(10, 5, multiplication);
            double result4 = calculator.Calculate(10, 0, division); 

            Console.WriteLine($"Addition: {result1}");
            Console.WriteLine($"Subtraction: {result2}");
            Console.WriteLine($"Multiplication: {result3}");
            Console.WriteLine($"Division: {result4}");
        }
    }
}