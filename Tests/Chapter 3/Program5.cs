using D = System.Console;

class A
{
    public void fun()
    {
        D.WriteLine("C# is Modern");
    }
}

class B
{
    public static void Main()
    {
        A a = new A();
        a.fun();
    }
}