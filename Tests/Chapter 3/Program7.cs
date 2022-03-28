// Multiple Main() Function
// For this program to work we need to mention the entry point while compiling
// e.g: csc Program7.cs /main:ICI

using A = System.Console;

class ICI
{
    public static void Main()
    {
        A.WriteLine("Enter your name");
        string Name = A.ReadLine();
        A.WriteLine("Hello " + Name);
    }
}

class NewClass
{
    public static void Main()
    {
        A.WriteLine("The Second Main Function is this");
    }
}