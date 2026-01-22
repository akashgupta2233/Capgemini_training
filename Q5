using System;

public class ExpressionEvaluator
{
    public string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        // 1. Split the string by spaces
        string[] parts = expression.Trim().Split(' ');

        // 2. Validate format (must be "a op b")
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        // 3. Validate numbers
        if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b))
            return "Error:InvalidNumber";

        string op = parts[1];

        // 4. Evaluate based on operator
        switch (op)
        {
            case "+":
                return (a + b).ToString();
            case "-":
                return (a - b).ToString();
            case "*":
                return (a * b).ToString();
            case "/":
                // 5. Check for Divide by Zero
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();
            default:
                return "Error:UnknownOperator";
        }
    }
}
