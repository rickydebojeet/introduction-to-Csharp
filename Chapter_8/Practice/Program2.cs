// Calling a static METHOD
using System;
class StaticMethod
{
    public static void Main()
    {
        double y = Square(2.5F); // METHOD call
        Console.WriteLine(y);
    }
    static double Square(float x) //METHOD defination
    {
        return (x * x);
    }
}