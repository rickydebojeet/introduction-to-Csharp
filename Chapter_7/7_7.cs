// dollar to ruppes converter
using System;
class DollarToRupees
{
    public static void Main()
    {
        float dol, rs, current;
        int i;
        Console.Write("What is the current value of 1 $ as per INDIAN Rs. : ");
        current = float.Parse(Console.ReadLine());
        Console.WriteLine(""); // Blank Line
        for (i = 1; i <= 5; i++)
        {
            Console.Write("Enter value " + i + " in Dollars : ");
            dol = float.Parse(Console.ReadLine());
            rs = dol * current;
            Console.WriteLine("$" + dol + " = " + rs + "Rs.");
            Console.WriteLine(""); // Blank Line
        }
        Console.ReadLine();
    }
}
