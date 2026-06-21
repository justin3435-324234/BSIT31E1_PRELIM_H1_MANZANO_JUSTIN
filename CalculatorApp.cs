using System;

class CalculatorApp
{
    private Calculator calc;

    public CalculatorApp()
    {
        calc = new Calculator();
    }

    public void Run()
    {
        while (true)
        {
            Console.Write("Enter first number (or 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            double num1 = Convert.ToDouble(input);

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = calc.Calculate(num1, num2, op);

            Console.WriteLine("= " + result);
            Console.WriteLine();
        }
    }
}