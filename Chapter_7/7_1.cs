// Reversal of a number;

using syc = System.Console;

class reverseNumber
{
    public static void Main()
    {
        syc.Write("Enter the number: ");
        int n = System.Convert.ToInt32(syc.ReadLine());
        int rev = 0;
        while (n != 0)
        {
            int tmp = n % 10;
            rev *= 10;
            rev += tmp;
            n /= 10;
        }
        syc.WriteLine("The number is {0}", rev);
    }
}