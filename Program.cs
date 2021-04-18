using System;

namespace experimentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            calculator.addTwo(num1, num2);
            Console.WriteLine("Result: ");
            Console.WriteLine(calculator.getCurrentValue());
        }
    }
}
