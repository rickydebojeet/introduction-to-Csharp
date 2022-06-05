using System;
using syc = System.Console;
class ex913
{
    public static void Main()
    {
        syc.Write("Enter the number of elements: ");
        int n = Convert.ToInt32(syc.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            syc.Write("Enter arr[{0}]= ", i);
            arr[i] = Convert.ToInt32(syc.ReadLine());
        }
        Array.Sort(arr);
        syc.WriteLine("The Min value is {0} and Max valus is {1}.", arr[0], arr[n - 1]);
    }
}