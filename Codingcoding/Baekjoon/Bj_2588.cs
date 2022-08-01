class Bj_2588
{
    public static void Mai()
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();

        int fn = int.Parse(firstNum);
        int sn = int.Parse(secondNum);

        string one = secondNum.Substring(2, 1);
        string two = secondNum.Substring(1, 1);
        string three = secondNum.Substring(0, 1);

        int one_num = int.Parse(one);
        int ten_num = int.Parse(two);
        int hundred_num = int.Parse(three);


        Console.WriteLine(fn * one_num);
        Console.WriteLine(fn * ten_num);
        Console.WriteLine(fn * hundred_num);
        Console.WriteLine(fn * sn);
    }
}