using syc = System.Console;
class ex109
{
    public static void Main()
    {
        string delim = " ,.";
        syc.Write("Please enter the text: ");
        string line = syc.ReadLine();
        string[] fields = line.Split(delim.ToCharArray());
        syc.WriteLine("The word count is {0}.", fields.Length);
    }
} 