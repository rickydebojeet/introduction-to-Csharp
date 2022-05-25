// Pattern Generator
using syc = System.Console;

class patternGenerator
{
    public static void Main()
    {
        int i, j, a, b, spaceLimit;
        syc.Write("Enter the number of max X in the pattern (in odd): ");
        int choice = System.Convert.ToInt32(syc.ReadLine());

        spaceLimit = 2 * (choice / 2);
        i = spaceLimit;
        j = 1;
        while (i >= 0 && j <= choice)
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
            i -= 2;
            j += 2;
        }
        i += 4;
        j -= 4;
        while (i <= spaceLimit && j >= 0)
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
            i += 2;
            j -= 2;
        }
    }
}