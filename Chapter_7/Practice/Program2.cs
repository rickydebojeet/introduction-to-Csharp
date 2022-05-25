// Demonstration of jump statement

using syc = System.Console;

class jumpDemo
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                goto Out;
            }
        }
    Out: syc.Write("Outside the loop");
    }
}