class Bj_10869
{
    public static void Mai()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(" ");

        int A = int.Parse(numbers[0]);
        int B = int.Parse(numbers[1]);

        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);
        Console.WriteLine(A % B);
    }
}