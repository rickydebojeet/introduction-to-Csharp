// A program with more than one class
using syc = System.Console;
// Class Definition
class testClass
{
    public void fun()
    {
        syc.WriteLine("C# is Modern");
    }
}

class program5
{
    public static void Main()
    {
        testClass ob1 = new testClass(); // Creating 'ob1' object
        ob1.fun(); // calling fun() function
    }
}