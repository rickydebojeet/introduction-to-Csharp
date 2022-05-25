// Use Switch & if statements to find the even sum & odd sum of integers between one to hundred
using syc = System.Console;

class sumCalculator
{
    public static void Main()
    {
        int evenSum = 0, oddSum = 0;
        for (int i = 1; i <= 100; i++)
        {
            int mod = i % 2;
            switch (mod)
            {
                case 0:
                    evenSum += i;
                    break;
                case 1:
                    oddSum += i;
                    break;
                default:
                    break;
            }
        }
        syc.WriteLine("The evensum is {0}.\nThe oddsum is {1}.", evenSum, oddSum);
    }
}