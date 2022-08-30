class Bj_25305
{
    public static void Mai()
    {
        //Input 응시생 수 N 상받는 사람 수 k
        //각 학생 점수 x
        string[] nk = Console.ReadLine().Split();
        int N = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        int[] scores = new int[N];

        string[] x = Console.ReadLine().Split();
        
        //INPUT으로 받은 string을 정수형으로 바꿔서 다시 배열로 저장
        for (int i = 0; i < N; i++)
        {
            scores[i] = int.Parse(x[i]);
        }

        //process 정렬 전의 scores 배열을 큰 순서대로 정렬한다. 그 배열에서 k-1번째 인덱스값을 출력하면 될듯
        
        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                int temp = 0;

                if (scores[i] < scores[j])
                {
                    temp = scores[i];
                    scores[i] = scores[j];
                    scores[j] = temp;
                }
            }
        }

        
        Console.WriteLine(scores[k - 1]);
    }
}
