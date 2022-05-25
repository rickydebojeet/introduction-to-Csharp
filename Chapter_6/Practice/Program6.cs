// Use of if else if ladder
/* 
|---------------------------|
| 80 - 100 | Honours        |
| 60 - 79  | Ist Division   |
| 50 - 59  | IInd Division  |
| 40 - 49  | IIIrd Division |
|  0 - 39  | Fail           |
|---------------------------|
*/

using syc = System.Console;
class rankAssigner
{
    public static void Main()
    {
        int[] Rno = { 111, 222, 333, 444 };
        int[] Marks = { 81, 65, 55, 35 };

        for (int i = 0; i < Rno.Length; i++)
        {
            if (Marks[i] >= 80)
                syc.WriteLine(Rno[i] + " Honours");
            else if (Marks[i] >= 60)
                syc.WriteLine(Rno[i] + " Ist Division");
            else if (Marks[i] >= 50)
                syc.WriteLine(Rno[i] + " IInd Division");
            else if (Marks[i] >= 40)
                syc.WriteLine(Rno[i] + " IIIrd Division");
            else
                syc.WriteLine(Rno[i] + " Fail");
        }
    }
}