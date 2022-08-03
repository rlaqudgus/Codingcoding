class Bj_2525
{
    public static void Mai()
    {
        //string[] hourAndMinute = Console.ReadLine().Split(" ");
        //int hour = int.Parse(hourAndMinute[0]);
        //int minute = int.Parse(hourAndMinute[1]);

        //int time = int.Parse(Console.ReadLine());

        //int endHour = hour;
        //int endMinute;

        //int plusHour = time / 60;
        //int plusMinute = time % 60;

        //endMinute = minute + time;

        //if (endMinute >= 60)
        //{

        //    endMinute = plusMinute;
        //    endHour = hour + plusHour;

        //    if (endHour>23)
        //    {
        //        endHour = endHour - 24;
        //    }
        //}

        //Console.WriteLine(endHour + " " + endMinute);
        Console.WriteLine("사각형의 너비를 입력하세요");
        string width = Console.ReadLine();
        Console.WriteLine("사각형의 높이를 입력하세요");
        string height = Console.ReadLine();

        int w = int.Parse(width);
        int h = int.Parse(height);

        Console.WriteLine($"사각형의 넓이는:{w*h}");
        float a = 0.1f;
        double b = 0.01;
        Console.WriteLine(a*b);
    }
}