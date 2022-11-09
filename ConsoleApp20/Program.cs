using ClassLibrary1;

class Program
{
    static void Main()
    { 
        Calculator calculator = new Calculator();
        calculator.X = 10;
        calculator.Y = 10;
        calculator.CurrentOperation = new MultiplyOperation();
        Console.WriteLine(calculator.Calc());
        calculator.CurrentOperation = new SumOperation();
        Console.WriteLine(calculator.Calc());
    }
}