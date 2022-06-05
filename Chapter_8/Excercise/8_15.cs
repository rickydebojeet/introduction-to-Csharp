using System;
using syc = System.Console;
class arrayFun
{
    public void arrayMan(int[] args)
    {
        int large = Max(args);
        int average = Average(args);
        syc.WriteLine("The largest element is {0} and average is {1}.", large, average);
    }
    int Max(int[] args)
    {
        int[] copy = args;
        Array.Sort(copy);
        Array.Reverse(copy);
        return (copy[0]);
    }
    int Average(int[] args)
    {
        int av = 0;
        foreach (int i in args)
        {
            av += i;
        }
        av /= args.Length;
        return av;
    }
}

class ex15
{
    public static void Main()
    {
        int[] num = {55, 40, 80, 65, 71};
        arrayFun trial = new arrayFun();
        trial.arrayMan(num);
    }
}