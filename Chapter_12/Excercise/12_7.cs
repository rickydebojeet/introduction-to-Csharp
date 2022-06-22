using System;
class date
{
    public int day, month, year;
    public date(int d, int m, int y)
    {
        day = d;
        month = m;
        year = y;
    }
    public date(int d)
    {
        year = d / 10000;
        month = d % 10000 / 100;
        day = d % 100;
    } 
    public void display()
    {
        Console.WriteLine("Date: " + day + "/" + month + "/" + year);
    }
}
class Origin
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        date d1 = new date(n);
        d1.display();
    }
}