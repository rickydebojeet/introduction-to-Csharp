using System;
class Investment
{
    public static void Main()
    {
        int P = 1000, n;
        float r = 0.1F;
        double V;
        Console.WriteLine("\n************** Investement Option of 10 yrs *****************");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("Principal(P) Rate(r) Number Of Yrs(n) Value Of Money(V)");
        Console.WriteLine("-------------------------------------------------------------");


        V = P * (1 + r);
        for (n = 1; n <= 10; n++)
        {
            Console.WriteLine("\t" + P + "\t" + r + "\t" + n + "\t\t" + V);


            P = P + 1000;
            r = r + 0.01F;
            V = P * (1 + r);
        }
        Console.ReadLine();
    }
}
