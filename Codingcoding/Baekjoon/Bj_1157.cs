class Bj_1157
{
    public static void Main()
    {
        //대문자와 소문자는 아스키코드로 32차이난다
        //Input
        string alphabet = Console.ReadLine();

        int[] array = new int[alphabet.Length];

        //Process
        //대문자와 소문자 구분 x 대문자 혹은 소문자로 통일시켜주는 과정
        
        for (int i = 0; i < alphabet.Length; i++)
        {
            int ascii = alphabet[i];
            if (ascii>90)
            {
                ascii = ascii - 32;
            }

            Console.Write(ascii+" ");
        }
        

    }
}
