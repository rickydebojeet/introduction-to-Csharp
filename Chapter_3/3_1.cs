/* 
A Program to read two strings from the keyboard using the ReadLine statements
and Display them on one line using two WriteLine Statements 
*/
using A = System.Console;
class StringReader
{
    public static void Main()
    {
        A.WriteLine("Enter the first string");
        string firstString = A.ReadLine();
        A.WriteLine("Enter the second string");
        string secondString = A.ReadLine();
        A.WriteLine(firstString + " " + secondString);
    }
}