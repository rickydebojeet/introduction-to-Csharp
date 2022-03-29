// Pattern Generator
using syc = System.Console;

class patternGenerator
{
    public static void Main()
    {
        int i, j, a, b;
        for (i = 4, j = 1; i >= 0 && j <= 5; i -= 2, j += 2)
        {
            a = i;
            b = j;
            while (a > 0)
            {
                syc.Write(" ");
                a--;
            }
            while (b > 0)
            {
                syc.Write("X ");
                b--;
            }
            syc.WriteLine("");
        }
        i += 4;
        j -= 4;
        for (; i <= 4 && j >= 0; i += 2, j -= 2)
        {
            a = i;
            b = j;
            while (a > 0)
            {
                syc.Write(" ");
                a--;
            }
            while (b > 0)
            {
                syc.Write("X ");
                b--;
            }
            syc.WriteLine("");
        }
    }
}