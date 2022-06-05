using syc = System.Console;
using System.Text;
class ex106
{
    public static void Main()
    {
        StringBuilder str = new StringBuilder();
        syc.Write("Please enter a text with three words: ");
        str.Append(syc.ReadLine());
        str.Replace(" ", "_");
        syc.WriteLine(str);
    }
}