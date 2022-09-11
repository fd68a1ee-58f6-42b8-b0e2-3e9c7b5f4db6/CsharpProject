internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Угадай");
        Random random = new();
        int target = random.Next(100);
        bool loop = true;
        while (loop)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < target)
            {
                Console.WriteLine("Число меньше загадоного");
            }
            else if (num > target)
            {
                Console.WriteLine("Число больше загадоного");
            }
            else
            {
                Console.WriteLine("Победа");
                loop = false;
            }
        }
    }
    private static void Main1()
    {
        Console.WriteLine("Угадай");
        Random random = new();
        int target = random.Next(100);
        bool loop = true;
        while (loop)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < target)
            {
                Console.WriteLine("Число меньше загадоного");
            }
            else if (num > target)
            {
                Console.WriteLine("Число больше загадоного");
            }
            else
            {
                Console.WriteLine("Победа");
                loop = false;
            }
        }
    }
}