using System;
class item
{
    static int code, price;
    static item()
    {
        code = 111;
        price = 1000;
    }
    public void display()
    {
        Console.WriteLine("Codes: " + code + " Price: " + price);
    }
}
class Origin
{
    public static void Main()
    {
        item i1 = new item();
        i1.display();
    }
}