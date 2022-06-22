using System;
class rectangle
{
    public int length, breadth;
    public rectangle(int l, int b)
    {
        length = l;
        breadth = b;
    }
    public rectangle(int l){
        length = breadth = l;
    }
    public int Area()
    {
        return length * breadth;
    }
}
class Origin
{
    public static void Main()
    {
        rectangle rect1 = new rectangle(15, 10);
        rectangle rect2 = new rectangle(30);
        int area1 = rect1.Area();
        Console.WriteLine("Area of rectangle 1 is " + area1);
        int area2 = rect2.Area();
        Console.WriteLine("Area of rectangle 2 is " + area2);
    }
}