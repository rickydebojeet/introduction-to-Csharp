// Using if as an identifier
using System;
class identifierExample
{
    public static void Main()
    {
        int @if;
        Console.WriteLine("Using @if as identifier:");
        for (@if = 0; @if < 10; @if++)
        {
            Console.WriteLine("The value of @if is: {0}", @if);
        }
    }
}