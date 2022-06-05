using syc = System.Console;
class ex108
{
    public static void Main()
    {
        syc.Write("Enter a string: ");
        string str = syc.ReadLine();
        syc.Write("Enter a character: ");
        char ch = System.Convert.ToChar(syc.ReadLine());
        int count = 0;
        foreach (char item in str)
        {
            if (item == ch)
                count++;
        }
        syc.WriteLine("Number of {0} is {1}", ch, count);
    }
}