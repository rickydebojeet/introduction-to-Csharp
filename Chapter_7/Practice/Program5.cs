// Check whether a number is prime or not unsing continue & break statementss
using syc = System.Console;

class primeDecider
{
    public static void Main()
    {
        int n, tmp = 0;
        syc.Write("Enter the number you want to check:");
        n = System.Convert.ToInt32(syc.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i != 0)
                continue;
            else
                tmp++;
            if (tmp > 2)
                break;
        }

        if (tmp == 2)
            syc.WriteLine("The number {0} is prime.", n);
        else
            syc.WriteLine("The number {0} is not prime.", n);
    }
}