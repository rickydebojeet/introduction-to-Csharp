// Command Line arguments as Input
using syc = System.Console;

class program4
{
    // For this to work we need to give argument while executing
    // e.g: Program4.exe C Sharp
    public static void Main(string[] args)
    {
        syc.WriteLine("Welcome To");
        syc.Write(args[0]);
        syc.Write(" " + args[1]);
    }
}