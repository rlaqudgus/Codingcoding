using System.Numerics;

class Bj_4375
{
    public static void Main()
    { 
        while (true)
        {

            string number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                break;
            }

            int n = int.Parse(number);

            BigInteger a = 1;
            BigInteger sum = 0;
            BigInteger sumsum;

            for (int i = 1; i < 100000; i++)
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