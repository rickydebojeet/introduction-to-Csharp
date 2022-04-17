// Demonstration of Loops

using syc = System.Console;
class loopDemo
{
    public static void Main()
    {
        int i = 1;
        syc.WriteLine("Using while loop:");
        while (i <= 10)
        {
            syc.Write(i + " ");
            i++;
        }
        syc.WriteLine();
        syc.WriteLine("Using do while loop:");
        do
        {

            syc.Write(i + " ");
            i--;
        } while (i > 0);
        syc.WriteLine();
        syc.WriteLine("Using for each loop:");
        int[] arr = { 10, 15, 20, 30, 40, 70 };
        foreach (int item in arr)
        {
            syc.Write(item + " ");
        }
        syc.WriteLine();
        syc.WriteLine("Using for loop:");
        for (i = 0; i < arr.Length; i++)
        {
            syc.Write(arr[i] + " ");
        }
        syc.WriteLine();
    }
}