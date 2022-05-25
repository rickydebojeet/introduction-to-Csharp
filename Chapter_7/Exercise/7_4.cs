// fibonacci
using System;
class fibonacci
{
    public static void Main()
    {
        int f, f1, f2, m, i = 1;
        Console.WriteLine("Enter the number of fibonacci values nedded:");
        m = Convert.ToInt32(Console.ReadLine());
        f = 0;
        f1 = 1;
        f2 = 1;
        do
        {
            i++;
            Console.Write("{0}" + " ", f);
            f1 = f2;
            f2 = f;
            f = f1 + f2;
        }
        while (i <= m);

    }
}