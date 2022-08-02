class Bj_2525
{
    public static void Main()
    {
        string[] hourAndMinute = Console.ReadLine().Split(" ");
        int hour = int.Parse(hourAndMinute[0]);
        int minute = int.Parse(hourAndMinute[1]);

        int time = int.Parse(Console.ReadLine());

        int endHour = hour;
        int endMinute;

        int plusHour = time / 60;
        int plusMinute = time % 60;

        endMinute = minute + time;

        if (endMinute >= 60)
        {
            
            endMinute = plusMinute;
            endHour = hour + plusHour;

            if (endHour>23)
            {
                endHour = endHour - 24;
            }
        }

        Console.WriteLine(endHour + " " + endMinute);
    }
}