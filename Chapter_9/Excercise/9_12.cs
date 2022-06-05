using syc = System.Console;
class ex912
{
    static bool Finder(int[] args)
    {
        syc.Write("Enter the element you want to find: ");
        int val = System.Convert.ToInt32(syc.ReadLine());
        foreach (int i in args)
        {
            if (i == val)
                return true;
        }
        return false;
    }
    public static void Main()
    {
        int[] args = { 55, 40, 80, 65, 71 };
        bool result = Finder(args);
        if (result)
            syc.WriteLine("The value is found.");
        else
            syc.WriteLine("The value is not found.");
    }
}