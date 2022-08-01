class Program
{
    public static void Main()
    {
        string number = Console.ReadLine();
        int n = int.Parse(number);        
        
        long a = 1;
        long sum=0;
        long sumsum;

        if (number.Length != 0)
        {
            for (int i = 1; i < 20; i++)
            {
                sum = 10 * sum;
                sumsum = sum + a;
                sum = sumsum;

                if (sumsum % n == 0)
                {
                    Console.WriteLine(sumsum.ToString().Length);
                    break;
                }
            }
        }
    }
}

