// Defining an output parameter
using syc = System.Console;

class Output
{
    static void Square(int x, out int y)
    {
        y = x * x;
    }
    public static void Main()
    {
        int m; // need not be iniitialized
        Square(10, out m);
        syc.WriteLine("m = " + m);
    }
}