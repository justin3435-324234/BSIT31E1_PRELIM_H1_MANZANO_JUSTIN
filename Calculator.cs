class Calculator
{
    public double Calculate(double num1, double num2, string op)
    {
        if (op == "+") return num1 + num2;
        if (op == "-") return num1 - num2;
        if (op == "*") return num1 * num2;
        if (op == "/") return num1 / num2;

        return double.NaN;
    }
}