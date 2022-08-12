class Bj_1157
{
    public static void Mai()
    {
        //대문자와 소문자는 아스키코드로 32차이난다
        //Input
        string alphabet = Console.ReadLine();

        int[] array = new int[26];

        int[] alphabetArray = new int[26];
        for (int i = 0; i < alphabetArray.Length; i++)
        {
            alphabetArray[i] = 65 + i;
        }

        //Process
        //대문자와 소문자 구분 x 대문자 혹은 소문자로 통일시켜주는 과정
        
        for (int i = 0; i < alphabet.Length; i++)
        {
            int ascii = alphabet[i];
            if (ascii>90)
            {
                ascii = ascii - 32;
            }
        //알파벳순서의 int배열 array에 단어 횟수를 집어넣음
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (alphabetArray[j]==ascii)
                {
                    array[j]++;
                }
            }
        }
        //array의 가장 큰 값의 인덱스 구하기
        int maxValue = 0;
        int maxValIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
                maxValIndex = i;
            }
        }
        //array에서 maxvalue가 중복되는지 확인
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue == array[i])
            {
                count++;
            }
        }

        //Output
        
        char result = (count >= 2) ? '?' : (char)(maxValIndex + 65);

        Console.WriteLine(result);

        //if (count >= 2)
        //{
        //    Console.WriteLine("?");
        //}

        //else
        //{
            

        //    Console.WriteLine(result);
        //}
    }
}
