class Bj_10809
{
    public static void Mai()
    {
        //Input
        string S = Console.ReadLine();

        // process
        // 배열에 알파벳순서의 인덱스값을 구해서 추가 반복문 통해?
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int[] array = new int[alphabet.Length];

        for (int i = 0; i < alphabet.Length; i++)
        {
            for (int j = 0; j < S.Length; j++)
            {
                if (alphabet[i] == S[j])
                {
                    array[i] = j;
                    break;
                }
                else
                    array[i] = -1;
            }
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
           
    }
}
