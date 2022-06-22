using System;
class rectangle
{
    public int length, breadth;
    public rectangle(int l, int b)
    {
        length = l;
        breadth = b;
    }
    public int Area()
    {
        return length * breadth;
    }
}
class rectangleArea
{
    public static void Main()
    {
        rectangle rect1 = new rectangle(15, 10);
        int area1 = rect1.Area();
        Console.WriteLine("Area of rectangle 1 is " + area1);
    }
}