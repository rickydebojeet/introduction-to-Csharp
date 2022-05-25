//* Nesting of Methods
using System;
class Nesting
{
    public void Largest(int m, int n)
    {
        int large = Max(m, n); // nesting
        Console.WriteLine(large);
    }
    int Max(int a, int b)
    {
        int x = (a > b) ? a : b;
        return x;
    }
}
class NestTesting
{
    public static void Main()
    {
        Nesting next = new Nesting();
        next.Largest(100, 200); //METHOD call
    }
}