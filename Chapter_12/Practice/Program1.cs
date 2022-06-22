using System;
class trialRectangle
{
    public int length, breadth;
    public void getData(int l, int b)
    {
        length = l;
        breadth = b;
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
        trialRectangle r1 = new trialRectangle();
        trialRectangle r2 = new trialRectangle();
        r1.length = 10;
        r1.breadth = 20;
        int area = r1.length * r1.breadth;
        Console.WriteLine("Area of rectangle 1 is " + area);
        r2.getData(30, 40);
        int newArea = r2.Area();
        Console.WriteLine("Area of rectangle 2 is " + newArea);
    }
}