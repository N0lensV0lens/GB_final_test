using System;

class Program
{
    static int GetUserInputSize()
    {
        Console.WriteLine("___Программа для вывода строк, длина которых меньше, либо равна 3 символам___");
        while (true)
        {
            // Запрос длины массива
            Console.WriteLine("Укажи размер массива: ");
            string size = Console.ReadLine();

            if (int.TryParse(size, out int number) && number > 0)
            {
                return number;
            }

            Console.WriteLine(number <= 0 ? "Введи положительное число" : "Нужно ввести числовое значение.");
        }
    }

