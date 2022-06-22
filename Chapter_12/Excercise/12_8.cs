using System;
class Time
{
    public int minutes, hours;
    public Time(int h, int m)
    {
        hours = h;
        minutes = m;
    }
    public Time(int m)
    {
        hours = m / 60;
        minutes = m % 60;
    }
    public void display()
    {
        Console.WriteLine("Time: " + hours + ":" + minutes);
    }
}
class Origin
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Time t1 = new Time(n);
        t1.display();
        Time t2 = new Time(10, 45);
        t2.display();
    }
}