// Sum of digits of a number;

using syc = System.Console;

class sumNumber
{
    public static void Main()
    {
        syc.Write("Enter the number: ");
        int n = System.Convert.ToInt32(syc.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            int tmp = n % 10;
            sum += tmp;
            n /= 10;
        }
        syc.WriteLine("The sum is {0}", sum);
    }
}