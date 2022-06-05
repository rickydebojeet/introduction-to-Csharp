using syc = System.Console;

class ex11
{
    static void Mult(int a, int b, out int c)
    {
        c = a * b;
    }
    public static void Main()
    {
        int product;    // Uninitialized
        Mult(5, 6, out product);
        syc.WriteLine("Product = " + product);
    }
}