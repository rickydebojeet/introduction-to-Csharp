// Use of if....else

class decision
{
    public static void Main()
    {
        int[] numbers = { 51, 60, 55, 72 };
        int even = 0, odd = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
                even++;
            else
                odd++;
        }
        System.Console.WriteLine("No. of even numbers is {0}.", even);
        System.Console.WriteLine("No. of odd numbers is {0}.", odd);
    }
}