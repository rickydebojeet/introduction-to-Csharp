// Excercise 6.9

using syc = System.Console;

class discountMaker
{
    public static void Main()
    {
        double purchase_amount, discount = 0, discount_price;
        string cloth_type;
        syc.Write("Enter the purchase amount:");
        purchase_amount = System.Convert.ToDouble(syc.ReadLine());
        syc.Write("Mill_Cloth or Handloom_Items?:  ");
        cloth_type = System.Convert.ToString(syc.ReadLine());
        switch (cloth_type)
        {
            case "Mill_Cloth":
                if (purchase_amount <= 100)
                {
                    discount = 0.0;
                }
                else if (purchase_amount <= 200)
                {
                    discount = 5.0;
                }
                else if (purchase_amount <= 300)
                {
                    discount = 7.5;
                }
                else
                {
                    discount = 10.0;
                }
                break;
            case "Handloom_Items":
                if (purchase_amount <= 100)
                {
                    discount = 5.0;
                }
                else if (purchase_amount <= 200)
                {
                    discount = 7.5;
                }
                else if (purchase_amount <= 300)
                {
                    discount = 10.0;
                }
                else
                {
                    discount = 15.0;
                }
                break;
            default:
                syc.WriteLine("Wrong Option.");
                break;
        }
        discount_price = purchase_amount - (purchase_amount * discount / 100);
        syc.WriteLine("The net amount to be paid is :" + discount_price);
    }
}