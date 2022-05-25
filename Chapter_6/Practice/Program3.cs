// Demonstration of nested if..else 
using syc = System.Console;

class ifElseNesting
{
    public static void Main()
    {
        int a = 325, b = 712, c = 478;
        syc.Write("Largest Value is: ");
        if(a > b)
        {
            if(a > c)
            {
                syc.WriteLine(a);
            }
            else
            {
                syc.WriteLine(c);
            }
        }
        else
        {
            if(c > b)
            {
                syc.WriteLine(c);
            }
            else
            {
                syc.WriteLine(b);
            }
        } 
    }
}