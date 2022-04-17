// Sum of array elements using for each 

using syc = System.Console;

class sumOfArray
{
    public static void Main()
    {
        int[] arr = { 10, 15, 12, 17, 20, 25 };
        int sum = 0;
        foreach (int item in arr)
        {
            sum += item;
        }
        syc.WriteLine("The sum is: {0}", sum);
    }
}