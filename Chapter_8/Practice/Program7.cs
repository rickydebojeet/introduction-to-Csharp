using syc = System.Console;

class methodOverloading
{
    public int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    public int Add(int a, int b, int c)
    {
        int d = a + b + c;
        return d;
    }
    public float Add(int a, float b)
    {
        float c = a + b;
        return c;
    }
    // public void Add(int a, int b)
    // {
    //     int c = a + b;
    //     syc.WriteLine(c);
    // }
}
class program807
{
    public static void Main()
    {
        methodOverloading m1 = new methodOverloading();
        int k = m1.Add(10, 20);
        syc.WriteLine(k);
        syc.WriteLine();
        int l = m1.Add(100, 200, 300);
        syc.WriteLine(l);
        syc.WriteLine();
        float n = m1.Add(10, 15.5f);
        syc.WriteLine(n);
        syc.WriteLine();
        // m1.Add(31, 69);
    }
}