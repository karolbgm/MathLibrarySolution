using MathLib;
using StringLib;

namespace MathLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        //using libraries
        Console.WriteLine(StringLibrary.Concat("Hello", "World"));
        Console.WriteLine(StringLibrary.UpperAndLower("test"));


        var answer = MathLib.Math.Add(11, 22); //Math is a class in System, so in this case Mathlib.Math would identify the class we want
        Console.WriteLine(answer);

        Console.WriteLine(MathLib.Math.Subtract(3, 2));
        Console.WriteLine(MathLib.Math.Multiply(3, 2));
        Console.WriteLine(MathLib.Math.Divide(4, 2));
        Console.WriteLine(MathLib.Math.Mod(10, 2));
        Console.WriteLine(MathLib.Math.Sqr(10));
        Console.WriteLine(MathLib.Math.Factorial(5));






    }
}
