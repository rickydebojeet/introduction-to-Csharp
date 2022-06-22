using System;
class item
{
    public int codes, price;
    public item(int c, int p)
    {
        codes = c;
        price = p;
    }
    public item(item i)
    {
        codes = i.codes;
        price = i.price;
    }
    public void display()
    {
        Console.WriteLine("Codes: " + codes + " Price: " + price);
    }
}
class Origin
{
    public static void Main()
    {
        item i1 = new item(111, 1000);
        item i2 = new item(i1);
        i1.display();
        i2.display();
    }
}