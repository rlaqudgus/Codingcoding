class Bj_2577
{
    public static void Main()
    {
        ////숫자의 개수 2577
        ////Input
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());

        ////Process
        //int d = a * b * c;
        ////Split을 이용하기 위해 d를 문자열로 바꿔서 total에 저장
        //string total = d.ToString();

        //int[] array = new int[10];

        ////Output
        //for (int i = 0; i < 10; i++)
        //{
        //    array[i] = total.Split(i.ToString()).Length - 1;
        //    Console.WriteLine(array[i]);
        //}


        ////이렇게할필요 없을것같음
        //int zeroCount = total.Split("0").Length - 1;
        //int oneCount = total.Split("1").Length - 1;
        //int twoCount = total.Split("2").Length - 1;
        //int threeCount = total.Split("3").Length - 1;
        //int fourCount = total.Split("4").Length - 1;
        //int fiveCount = total.Split("5").Length - 1;
        //int sixCount = total.Split("6").Length - 1;
        //int sevenCount = total.Split("7").Length - 1;
        //int eightCount = total.Split("8").Length - 1;
        //int nineCount = total.Split("9").Length - 1;

        // 나머지 3052
        //Input
        int [] array = new int[10];

        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());
            array[i] = number;
            Console.WriteLine(array[i] % 42);
        }

        //Process 나왔는지 안나왔는지?? 체크

        //OX퀴즈 8958
        //Input

        int caseNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < caseNumber; i++)
        {
            Console.ReadLine();
        }

        //최대,최소 10818
        //Input
        int numbers = int.Parse(Console.ReadLine());
        string[] numberss = Console.ReadLine().Split(" ");
        int[] newNumber = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            newNumber[i]=int.Parse(numberss[i]);
        }

        for (int i = 0; i < numbers-1; i++)
        {
            for (int j = 1; j < numbers; j++)
            {
                if (newNumber[i]>newNumber[j])
                {
                    int temp = newNumber[i];
                    newNumber[i] = newNumber[j];
                    newNumber[j] = temp;
                }
            }
        }

        int min = newNumber[0];
        int max = newNumber[newNumber.Length-1];

        Console.WriteLine();




    }
}
