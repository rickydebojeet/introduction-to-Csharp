/* 
Two classes are defined one with a method to display the string "C Sharp" and
the other to display the string "Programming". The program uses these classes
to display a single line output as follows: "C Sharp Programming"
*/

using syc = System.Console;

class firstString
{
    public void display()
    {
        syc.Write("C Sharp");
    }
}

class secondString
{
    public void display()
    {
        syc.Write("Programming");
    }
}

class origin
{
    public static void Main()
    {
        firstString a = new firstString();
        secondString b = new secondString();
        a.display();
        syc.Write(" ");
        b.display();
        syc.WriteLine(" ");
    }
}