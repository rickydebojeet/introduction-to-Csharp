using System;
class Person
{
    protected int age;
    protected string name;
    protected string sex;
    public Person(int a, string n, string s)
    {
        this.age = a;
        this.name = n;
        this.sex = s;
    }
    public virtual void Display()
    {
        Console.Write("Name: {0}\tAge: {1}\tSex: {2}", name, age, sex);
    }
}
class Employee : Person
{
    protected int code;
    public Employee(int a, string n, string s, int c) : base(a, n, s)
    {
        this.code = c;
    }
    public override void Display()
    {
        Console.WriteLine("Employee");
        base.Display();
        Console.WriteLine("\tEmployee Code: {0}", code);
    }
}
class Specialist : Employee
{
    public Specialist(int a, string n, string s, int c) : base(a, n, s, c)
    {
        this.age = a;
        this.name = n;
        this.sex = s;
        this.code = c;
    }
    public override void Display()
    {
        Console.Write("Specialist ");
        base.Display();
    }
}
class Origin
{
    public static void Main()
    {
        Employee[] e = new Employee[3];
        e[0] = new Employee(22, "Debojeet Das", "Male", 055);
        e[1] = new Employee(26, "Swaubhik Chakraborty", "Male", 299);
        e[2] = new Employee(25, "Sourav Kumar Biswal", "Male", 057);
        foreach(Employee emp in e)
        {
            emp.Display();
        }
        Specialist[] f = new Specialist[3];
        f[0] = new Specialist(34, "Tarun Das", "Male", 025);
        f[1] = new Specialist(26, "Dora Das", "Female", 099);
        f[2] = new Specialist(25, "Sourav Kumar Biswal", "Male", 057);
        foreach(Specialist emp in f)
        {
            emp.Display();
        }
    }
}