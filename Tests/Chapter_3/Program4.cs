// Command Line arguments as Input

using A = System.Console;

class program4
{
    // For this to Work We need to give argument while executing
    // e.g: Program4.exe C Sharp
    public static void Main(string[] B)
    {
        A.WriteLine("Welcome To");
        A.Write(B[0]);
        A.Write(" " + B[1]);
    }
}