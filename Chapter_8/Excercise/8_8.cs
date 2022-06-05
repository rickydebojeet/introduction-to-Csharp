using syc = System.Console;

class ex8
{
    public static void Space(int n)
    {
        for(int i = 0; i < n; i++)
        {
            syc.Write(" ");
        }
    }
    public static void Main()
    {
        syc.Write("Enter the first number: ");
        int a = System.Convert.ToInt32(syc.ReadLine());
        syc.Write("Enter the second number: ");
        int b = System.Convert.ToInt32(syc.ReadLine());
        syc.Write("Enter the spaces: ");
        int c = System.Convert.ToInt32(syc.ReadLine());
        syc.Write(a);
        Space(c);
        syc.WriteLine(b);
    }
}