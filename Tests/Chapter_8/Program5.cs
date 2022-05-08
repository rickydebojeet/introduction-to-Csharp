// * Passing values using ref parameter
using System;
class PassByRef
{
    static void swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    public static void Main()
    {
        int m = 100;
        int n = 200;
        Console.WriteLine("Before Swapping");
        Console.WriteLine("m =" + m);
        Console.WriteLine("n =" + n);
        swap(ref m, ref n);
        Console.WriteLine("After Swapping");
        Console.WriteLine("m =" + m);
        Console.WriteLine("n =" + n);
    }
}