using System;
using System.Text;
class Bj_10757
{
    public static void Main()
    {
        //큰수덧셈 10757
        //string[] numArray = Console.ReadLine().Split();

        //ulong a = ulong.Parse(numArray[0]);
        //ulong b = ulong.Parse(numArray[1]);

        //Console.WriteLine(a + b);
        //아 이 문제는 단순히 더하는게 아니고 큰 수의 덧셈을 구현해야하는구나

        //부녀회장 2775
        //Input 반복문 T번 반복 k 다음줄 n
        int T = int.Parse(Console.ReadLine());

        int[] newArray = new int[14];

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            int[] zeroArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
           

            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            //process k층 n호에 몇명 살고 있는지 계산 변수에 저장 변수를 스트링빌더에 넣고 한꺼번에 출력
            //k층 각 호수 인원들의 배열 만들기
            
            
            int count = 0;
            while (count<k)
            {
                int zeroSum = 0;
                for (int j = 0; j < zeroArray.Length; j++)
                {
                    
                    zeroSum += zeroArray[j];
                    newArray[j] = zeroSum;
                }

                for (int l = 0; l < 14; l++)
                {
                    zeroArray[l] = newArray[l];
                }
                count++;
            }

            sb.AppendLine(newArray[n-1].ToString());
            /*{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };*/
        }
        Console.WriteLine(sb);
    }
}

