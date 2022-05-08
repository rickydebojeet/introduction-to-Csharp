// * Write a method space(int k) that can be used to provide a space of k portions between output of two numbers
using System;
class spaceBetween
{
    public static void Main()
    {
        int a = 100, b = 200, sp;
        Console.Write("Enter the number of space you need:\t");
        sp = Convert.ToInt32(Console.ReadLine());
        Console.Write(a);
        space(sp);
        Console.Write(b);
    }
    static void space(int k)
    {
        for (int i = 0; i < k; i++)
        {
            Console.Write(" ");
        }
        return;
    }
}