using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string inp = Console.ReadLine();
        char[] chars = inp.ToCharArray();
        string num1 = "";
        string num2 = "";
        char sing = ']';
        bool isFirst = true;
        for(int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >=48 && chars[i] <=57 && isFirst)
            {
                num1 += chars[i].ToString();
            }
            else if (chars[i] >= 48 && chars[i] <= 57 && !isFirst)
            {
                num2 += chars[i].ToString();
            }
            if (chars[i] == 42 || chars[i] == 43 || chars[i] == 45 || chars[i] == 47)
            {
                sing = chars[i];
                isFirst = false;
            }
            if (chars[i] == 33)
            {
                sing = chars[i];
                break;
            }
        }
        switch (sing)
        {
            case '*':
                Console.WriteLine(int.Parse(num1) * int.Parse(num2));
                break;
            case '/':
                Console.WriteLine(int.Parse(num1) / int.Parse(num2));
                break;
            case '+':
                Console.WriteLine(int.Parse(num1) + int.Parse(num2));
                break;
            case '-':
                Console.WriteLine(int.Parse(num1) - int.Parse(num2));
                break;
            case '!':
                int result = 1;
                for (int i = 1; i <= int.Parse(num1); i++)
                {
                    result = result * i;
                }
                Console.WriteLine(result);
                break;
            case ']':
                Console.WriteLine("Wrong input");
                break;
        }
    }
}