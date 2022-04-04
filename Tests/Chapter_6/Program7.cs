// Use of switch-case
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
class switchRank
{
    public static void Main()
    {
        int[] Rno = { 111, 222, 333, 444 };
        int[] Marks = { 81, 65, 55, 35 };

        for (int i = 0; i < Rno.Length; i++)
        {
            int val = Marks[i] / 10;
            switch (val)
            {
                case 10:
                case 9:
                case 8:
                    syc.WriteLine(Rno[i] + " Honours");
                    break;
                case 7:
                case 6:
                    syc.WriteLine(Rno[i] + " Ist Division");
                    break;
                case 5:
                    syc.WriteLine(Rno[i] + " IInd Division");
                    break;
                case 4:
                    syc.WriteLine(Rno[i] + " IIIrd Division");
                    break;
                default:
                    syc.WriteLine(Rno[i] + " Fail");
                    break;
            }
        }
    }
}