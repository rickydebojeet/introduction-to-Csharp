using System.Collections;
using syc = System.Console;

class ProgramFinder
{
    public bool rwn(ArrayList arr)
    {
        syc.Write("Enter the string you want to search: ");
        string find = syc.ReadLine();
        bool result = arr.Contains(find);
        return result;
    }
}
class Program903
{
    public static void Main()
    {
        ProgramFinder obj = new ProgramFinder();
        ArrayList cities = new ArrayList();
        cities.Add("Kolkata");
        cities.Add("Guwahati");
        cities.Add("Kokrajhar");
        if (obj.rwn(cities))
        {
            syc.WriteLine("The string is present!");
        }
        else
        {
            syc.WriteLine("The string is absent!");
        }
    }
}