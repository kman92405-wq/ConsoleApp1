using System;

class Program
{
    static void Main()
    {
        // Запрос числа у пользователя
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();
        double x;

        // Проверка на корректность ввода
        bool rez = double.TryParse(input, out x);
        if (rez == false)
        {
            Console.WriteLine("Неверный формат ввода, должно быть double");
            return;
        }

        // Вычисление значения функции 3 * sin(x + 2)
        double final = 3 * Math.Sin(x + 2);
        Console.WriteLine($"Результат: {final}");

        // Подпись автора
        Console.WriteLine("Работу выполнил Сорокин Владимир, Цуканов Федор 23ИС");

        Console.ReadKey();
    }
}



