namespace MathLib;

public static class Math
{
    public static int Add (int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    public static int Mod(int num1, int num2)
    {
        return num1 - num2 * (num1 / num2);
    }

    public static double Sqr(int num1)
    {
        return System.Math.Pow(num1, 2);
    }

    public static int Factorial(int num1)
    {
        var factorial = 1;
        for (int i = num1; i > 0; i--)
        {
            factorial *= i;

        }
        return factorial;

    }
}
