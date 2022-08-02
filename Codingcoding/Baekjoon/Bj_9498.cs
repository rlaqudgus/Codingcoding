class Bj_9498
{
    public static void Mai()
    {
        int testScore = int.Parse(Console.ReadLine());

        if (testScore >= 90)
        {
            Console.WriteLine("A");
        }
        else if (80 <= testScore && testScore < 90)
        {
            Console.WriteLine("B");
        }
        else if (70 <= testScore && testScore < 80)
        {
            Console.WriteLine("C");
        }
        else if (60 <= testScore && testScore < 70)
        {
            Console.WriteLine("D");
        }
        else
            Console.WriteLine("F");
    }
}