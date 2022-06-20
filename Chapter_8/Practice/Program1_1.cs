class cubeVolume
{
    public int cube(int x)
    {
        int k = x * x * x;
        return k;
    }
    public static void Main()
    {
        cubeVolume m = new cubeVolume();
        int y = m.cube(10);
        System.Console.WriteLine("Cube " + y);
    }
}