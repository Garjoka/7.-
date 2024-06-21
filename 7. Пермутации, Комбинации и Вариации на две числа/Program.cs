using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int k = int.Parse(Console.ReadLine());

        int permutations = Permutations(n, k);
        int combinations = Combinations(n, k);
        int variations = Variations(n, k);

        Console.WriteLine($"Permutations: {permutations}, Combinations: {combinations}, Variations: {variations}");
    }

    static int Permutations(int n, int k)
    {
        return Factorial(n) / Factorial(n - k);
    }

    static int Combinations(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static int Variations(int n, int k)
    {
        return (int)Math.Pow(n, k);
    }

    static int Factorial(int x)
    {
        if (x == 0) return 1;
        int result = 1;
        for (int i = 1; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }
}
