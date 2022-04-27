// Multiple Main() Function
// For this program to work we need to mention the entry point while compiling
// e.g: csc Program7.cs /main:ICI

using syc = System.Console;

class ICI
{
    public static void Main()
    {
        syc.WriteLine("Enter your name");
        string Name = syc.ReadLine();
        syc.WriteLine("Hello " + Name);
    }
}

class NewClass
{
    public static void Main()
    {
        syc.WriteLine("The Second Main Function is this");
    }
}