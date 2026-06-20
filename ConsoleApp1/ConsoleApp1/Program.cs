using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Calculator object
        Calculator calc = new Calculator();

        while (true)
        {
            Console.Write("Enter first number (or 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            double num1 = Convert.ToDouble(input);

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            // Check for division by zero before processing
            if (op == "/" && num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                continue;
            }

            // Call the class method to calculate the result
            double result = calc.Calculate(num1, num2, op);

            // Handle invalid operator return value
            if (double.IsNaN(result))
            {
                Console.WriteLine("Invalid operator.");
                continue;
            }

            Console.WriteLine("=: " + result);
            Console.WriteLine();
        }

        Console.WriteLine("Program ended.");
    }
}

// New dedicated Calculator class
class Calculator
{
    public double Calculate(double num1, double num2, string op)
    {
        switch (op)
        {
            case "+": return num1 + num2;
            case "-": return num1 - num2;
            case "*": return num1 * num2;
            case "/": return num1 / num2;
            default: return double.NaN; // Returns 'Not a Number' if operator is invalid
        }
    }
}
