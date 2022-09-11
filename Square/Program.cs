internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);
    }
}