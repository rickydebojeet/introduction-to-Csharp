/* 
A program that takes the line of text
"John F Kennedy"
as a command line input and displays the following output
"Kennedy John F"
*/

using syc = System.Console;

class nameChnager
{
    public static void Main(string[] args)
    {
        syc.WriteLine(args[2] + " " + args[0] + " " + args[1]);
    }
}