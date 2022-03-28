using A = System.Console;

class ICI
{
    public static void Main()
    {
        A.WriteLine("Enter your name");
        string Name = A.ReadLine();
        A.WriteLine("Hello " + Name);
    }
}