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
    public void display()
    {
        Console.WriteLine("Date: " + day + "/" + month + "/" + year);
    }
}
class Origin
{
    public static void Main()
    {
        date d1 = new date(1, 1, 2000);
        d1.display();
    }
}