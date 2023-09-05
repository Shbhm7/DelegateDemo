namespace DelegateDemo
{
    public class Calculator
    {
        public double Calculate(double operand1, double operand2, ArithmeticOperation operation)
        {
            return operation(operand1, operand2);
        }
    }
}