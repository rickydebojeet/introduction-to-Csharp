using syc = System.Console;

class factorial
{
    public static void Main()
    {
        syc.Write("Enter the number: ");
        int n = System.Convert.ToInt32(syc.ReadLine());
        int fact = 1;
        while (n != 0)
        {
            fact *= n;
            n--;
        }
        syc.WriteLine("The factorial is: {0}", fact);
    }
}