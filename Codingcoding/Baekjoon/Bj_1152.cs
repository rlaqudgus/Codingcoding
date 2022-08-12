class Bj_1152
{
    public static void Mai()
    {
        string sentence = Console.ReadLine();
        string[] array = sentence.Split(" ");

        int arrayNum = array.Length;

        if (array[0]=="")
        {
            arrayNum -= 1;
        }

        if (array[array.Length - 1] == "")
        {
            arrayNum -= 1;
        }

        Console.WriteLine(arrayNum);
    }
}
