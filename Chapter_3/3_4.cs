/*
The Program assigns two double type values to two variables, computes their sum,
assigns the result to a third variable, and displays all the tree values in one
line of output.
*/

using syc = System.Console;

class adder
{
    public static void Main()
    {
        double a = 2.7, b = 3.1, c;
        c = a + b;
        syc.WriteLine(a + " " + b + " " + c);
    }
}