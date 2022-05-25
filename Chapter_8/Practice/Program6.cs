//* Use output Parameter to find the evenSum and oddSum of integers between 50 to 100

using System;

class sumCalculator
{
    static void even(out int evenSum)
    {
        evenSum = 0;
        for (int i = 50; i <= 100; i++)
        {
            if ((i % 2) == 0)
            {
                evenSum += i;
            }
        }
    }
    static void odd(out int oddSum)
    {
        oddSum = 0;
        for (int i = 50; i <= 100; i++)
        {
            if ((i % 2) != 0)
            {
                oddSum += i;
            }
        }
    }
    public static void Main()
    {
        int evenSum = 0, oddSum = 0;
        even(out evenSum);
        Console.WriteLine("Even Sum = " + evenSum);
        odd(out oddSum);
        Console.WriteLine("Odd Sum = " + oddSum);
    }
}
