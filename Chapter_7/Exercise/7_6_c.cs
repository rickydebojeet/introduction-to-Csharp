using syc = System.Console;

class Pyramid
{
    public static void Main()
    {
        syc.Write("Enter the pyramid size: ");
        int n = System.Convert.ToInt32(syc.ReadLine());
        syc.WriteLine("");
        for (int i = 1; i <= n; i++)
        {
            for (int j = n - i; j > 0; j--)
            {
                syc.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                syc.Write(i + " ");
            }
            syc.WriteLine("");
        }
    }
}