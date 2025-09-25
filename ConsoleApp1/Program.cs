using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();
        double x;

        bool rez = double.TryParse(input, out x);
        if (rez == false)
        {
            Console.WriteLine("Неверный формат ввода, должно быть double");
            return;
        }

        double final = 3 * Math.Sin(x + 2);
        Console.WriteLine($"Результат: {final}");
        Console.ReadKey();
    }
}


