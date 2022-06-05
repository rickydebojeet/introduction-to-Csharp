using syc = System.Console;
using System;

class ex107
{
    static string SortString(string input)
    {
        char[] characters = input.ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
    public static void Main()
    {
        syc.Write("Please enter a string: ");
        string str = syc.ReadLine();
        string str1 = SortString(str);
        syc.WriteLine(str1);
    }
}