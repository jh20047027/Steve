using System;

class FibonacciCalculator
{
    static void Main()
    {
        Console.Write("請輸入費式數列項數: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0;
        int b = 1;
        int result = 0;

        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }
}
