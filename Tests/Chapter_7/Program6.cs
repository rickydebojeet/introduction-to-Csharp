// Use Jump statement to find the max of three integers
using syc = System.Console;

class maxDecider
{
    public static void Main()
    {
        int a, b, c, max;
        syc.Write("Enter the first number:");
        a = System.Convert.ToInt32(syc.ReadLine());
        syc.Write("Enter the second number:");
        b = System.Convert.ToInt32(syc.ReadLine());
        syc.Write("Enter the third number:");
        c = System.Convert.ToInt32(syc.ReadLine());
        max = a;

        if (b > c)
            goto CheckB;
        else
            goto CheckC;

        CheckB: if (a > b)
            goto PrintA;
        else
            goto PrintB;
        CheckC: if (c > a)
            goto PrintC;
        else
        {
            syc.WriteLine("Error");
            goto Out;
        }

    PrintA: syc.WriteLine("{0} is largest.", a);
        goto Out;

    PrintB: syc.WriteLine("{0} is largest.", b);
        goto Out;

    PrintC: syc.WriteLine("{0} is largest.", c);
        goto Out;

    Out: syc.WriteLine("Exiting...");
    }
}