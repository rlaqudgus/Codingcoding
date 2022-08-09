class Bj_4673
{
    public static void Main()
    {
        //4673
        //Input
        //없음
        
        //int d(string sN)
        //{
        //    int nSn = int.Parse(sN);

        //    for (int i = 0; i < sN.Length; i++)
        //    {
        //        int solo = int.Parse(sN[i].ToString());
        //        nSn += solo;
        //    }
        //    return nSn;
        //}

        int d (int Num)
        {

            if (Num >= 10000)
                return 0; 

            string Numstr = Num.ToString();

             

            for (int i = 0; i < Numstr.Length; i++)
            {
                int a = int.Parse(Numstr[i].ToString());

                Num += a;
            }

            Console.WriteLine(Num);

            return d(Num);
        }

       

        int count = 0;
        while (count<=10000)
        {

            count++;
        }
        //1065 한수
        
    }
}
