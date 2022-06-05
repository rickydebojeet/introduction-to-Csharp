using syc = System.Console;
using System.Text;
class ex104
{
    public static void Main()
    {
        syc.Write("Enter the first name: ");
        string fn = syc.ReadLine();
        syc.Write("Enter the second name: ");
        string ln = syc.ReadLine();
        string name = fn + " " + ln;
        syc.WriteLine(name);
        StringBuilder newName = new StringBuilder();
        newName.Append(fn);
        newName.Append(" ");
        newName.Append(ln);
        syc.WriteLine(newName);
    }
}