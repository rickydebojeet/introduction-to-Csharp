using syc = System.Console;

class StarGenerator
{
    public static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            syc.WriteLine("");
            if (i >= 10)
                break;
            for (int j = 1; j < 100; j++)
            {
                syc.Write("*");
                if (j == i)
                    goto Loop1;
            }
        Loop1: continue;
        }
        syc.WriteLine("Termination By Break");
    }
}