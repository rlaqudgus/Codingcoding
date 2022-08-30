class Bj_2750
{
    public static void Mai()
    {
        //Input N개의 수 줄바꾸면서 수 입력
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                int temp = 0;

                if (numbers[i] > numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}