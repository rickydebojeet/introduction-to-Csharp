// * Write a method that will return TRUE if the arguments id prime number otherwise FALSE
using System;

namespace Method
{

    class Prime
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:\t");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = primeDecider(num);
            Console.WriteLine(result);
        }
        static Boolean primeDecider(int x)
        {
            int a = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}