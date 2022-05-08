//* Write a method to enter "Central Institute Of Technology kokkrajhar" as input and calculate the number 
//* of blank spaces available in the string
using System;
public class spaceCalculator
{
    public static int SpaceCount(string str)
    {
        int spcctr = 0;
        string str1;
        for (int i = 0; i < str.Length; i++)
        {
            str1 = str.Substring(i, 1);
            if (str1 == " ")
                spcctr++;
        }
        return spcctr;
    }
    public static void Main()
    {
        string str2;
        Console.Write("\nFunction to count number of spaces in a string :\n");
        Console.Write("---------------------------------------------------\n");
        Console.Write("Please input a string : ");
        str2 = Console.ReadLine();
        Console.WriteLine("\"" + str2 + "\"" + " contains {0} spaces", SpaceCount(str2));
    }
}