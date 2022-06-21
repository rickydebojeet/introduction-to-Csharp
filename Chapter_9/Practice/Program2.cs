using System.Collections;
using syc = System.Console;
class Alist
{
    public static void Main()
    {
        ArrayList cities = new ArrayList();
        syc.Write("How many cities do you want to enter: ");
        int n = System.Convert.ToInt32(syc.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string city = syc.ReadLine();
            cities.Add(city);
        }
        foreach (string city in cities)
        {
            syc.WriteLine(city);
        }
    }
}