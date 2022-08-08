class Bj_10430
{
    public static void Mai()
    {
        string[] numArray = Console.ReadLine().Split();
        int a = int.Parse(numArray[0]);
        int b = int.Parse(numArray[1]);
        int c = int.Parse(numArray[2]);

        Console.WriteLine((a + b) % c);
        Console.WriteLine(((a % c) + (b % c)) % c);
        Console.WriteLine((a * b) % c);
        Console.WriteLine(((a % c)*(b % c) )% c);
    }
}
