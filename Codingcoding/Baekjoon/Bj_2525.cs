class Bj_2525
{
    public static void Mai()
    {
        //Input
        string[] hourAndMinute = Console.ReadLine().Split(" ");
        int hour = int.Parse(hourAndMinute[0]);
        int minute = int.Parse(hourAndMinute[1]);

        int time = int.Parse(Console.ReadLine());

        //Process
        int plusHour = time / 60;
        int plusMinute = time % 60;

        

        int finalHour = hour + plusHour;
        int finalMinute = minute + plusMinute;

        while (finalMinute >= 60)
        {
            finalMinute = finalMinute - 60;
            finalHour++;
        }

        while (finalHour >= 24)
        {
            finalHour = finalHour - 24;
        }

        
        //Output

        Console.WriteLine($"{finalHour} {finalMinute}");
    }
}