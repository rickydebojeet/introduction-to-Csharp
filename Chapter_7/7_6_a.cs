//Program to print this
// 1
// 22
// 333
// 4444
// 55555
using System;
class DollarDesign
{
    public static void Main()
    {
        int no = 1, i, j;
        for (i = 1; i < 6; i++) // Outer loop for incrememting the numbers to be displayed
        {
            Console.WriteLine(" "); // Leave a line after each new number
            for (j = 1; j < 6; j++) // Inner loop to specify the numer of times the particular number is to be printed.
            {
                Console.Write(no);
                if (i == j)
                // If a number is printed that many number of times ...
                // e.g. If 3 is there. The if 3 is printed 3 times, then this condition arises
                {
                    no = no + 1; // Increment the number
                    goto loop1; // Goto outer loop
                }
            }
        loop1: continue;
        }
        Console.ReadLine();
    }
}