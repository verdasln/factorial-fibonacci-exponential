using System;

class Program
{
    // faktöriyel (n!)
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    // fibonacci (n. fibonacci sayısı)
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // exponential us alma
    static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1;
        else
            return baseNum * Power(baseNum, exponent - 1);
    }

    static void Main(string[] args)
    {
        // faktoriyel ornegi
        int num = 5;
        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");

        // fibonacci ornegi
        int fibPos = 7;
        Console.WriteLine($"Fibonacci number at position {fibPos} is {Fibonacci(fibPos)}");

        // exponential ornegi
        int baseNum = 2;
        int exponent = 4;
        Console.WriteLine($"{baseNum} to the power of {exponent} is {Power(baseNum, exponent)}");
    }
}