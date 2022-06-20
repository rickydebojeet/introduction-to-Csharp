using System;
class ex110a
{
    public static void Main()
    {
        string[] names = { "Debojeet", "Akash", "Navin", "Gautam", "Priyanshu", "Swaubhik", "Durlabh" };
        string temp;
        for (int j = 0; j < names.Length - 1; j++)
        {
            for (int i = 0; i < names.Length - j - 1; i++)
            {
                if (string.Compare(names[i], names[i + 1]) == 1)
                {
                    temp = names[i];
                    names[i] = names[i + 1];
                    names[i + 1] = temp;
                }
            }
        }
        foreach (string item in names)
        {
            Console.WriteLine(item);
        }
    }
}