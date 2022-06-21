// Program to take 20 int from stdin & pick the smallest, greatest & the middle one
using System;

class arr
{
    public static void Main()
    {
        int[] A = new int[20];
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("Enter {0} elemtnt: ", i + 1);
            A[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(A);
        Console.WriteLine("The smallest elemtent is {0}.", A[0]);
        Console.WriteLine("The greatest element is {0}.", A[A.Length - 1]);
        Console.WriteLine("The middle element is {0}.", A[A.Length / 2]);
    }
}