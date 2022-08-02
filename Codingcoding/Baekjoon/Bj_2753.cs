class Bj_2753
{
    public static void Mai()
    {
        int yunYear = int.Parse(Console.ReadLine());

        if ((yunYear%4==0 && yunYear%100!=0) || yunYear%400==0)
        {
            Console.WriteLine(1);
        }
        else
            Console.WriteLine(0);
    }
}