class Bj_2884
{
    public static void Mai()
    {
        
        string[] hourAndMinute = Console.ReadLine().Split(" ");
        int hour = int.Parse(hourAndMinute[0]);
        int minute = int.Parse(hourAndMinute[1]);

        int alarmHour = hour;
        int alarmMinute;

        alarmMinute = minute - 45;

        if (alarmMinute<0)
        {
            alarmMinute = 60 + alarmMinute;
            alarmHour = hour - 1;

            if (alarmHour<0)
            {
                alarmHour = 23;
            }

        }

        Console.WriteLine(alarmHour+" "+alarmMinute);
        
    }
}