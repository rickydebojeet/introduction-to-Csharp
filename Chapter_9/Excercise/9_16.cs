using System;
using syc = System.Console;
class ex916
{
    static int[] appender(int[] arr1, int[] arr2)
    {
        int c = arr1.Length + arr2.Length;
        int[] arr3 = new int[c];
        for(int i = 0; i < c; i++)
        {
            if(i < arr1.Length)
                arr3[i] = arr1[i];
            else
            {
                int j = i % arr1.Length;
                arr3[i] = arr2[j];
            }
        }
        return arr3;
    }
    public static void Main()
    {
        int[] a1 = {50, 40, 30};
        int[] a2 = {80, 65, 71};
        int[] a3 = appender(a1, a2);
        foreach (int item in a3)
        {
            syc.Write(item + " ");
        }
        syc.WriteLine("");
    }
}