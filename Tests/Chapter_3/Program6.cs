// Interactive Console Input
using syc = System.Console;

class ICI
{
    public static void Main()
    {
        syc.WriteLine("Enter your name");
        string name = syc.ReadLine();
        syc.WriteLine("Hello " + name);
    }
}