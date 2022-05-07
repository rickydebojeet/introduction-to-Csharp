// defining and invoking a method
using System;
class Method //class containing the method
{
    // DEFINE THE CUBE METHOD
    int Cube(int x)
    {
        return (x * x * x);
    }
}
// Client class to invoke the cube method
class MethodTest
{
    public static void Main()
    {
        // CREATE OBJECT FOR INVOKING CUBE
        Method M = new Method();
        // INVOKING THE CUBE METHOD
        int y = M.Cube(5); //Method call
        //RESULT
        Console.WriteLine(y);

    }
}