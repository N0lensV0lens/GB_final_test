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

    static string[] GetUserInput(int size)
    {
        string[] inputs = new string[size];

        // Запрос ввода текста
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Осталось ввести строк {size - i}: ");
            inputs[i] = Console.ReadLine();
        }

        // Создаём новый массив для строк длиной <= 3
        string[] shortStrings = new string[size];
        int count = 0;

        // Сохраняем строки длиной <= 3 в новый массив
        for (int i = 0; i < size; i++)
        {
            if (inputs[i].Length <= 3 && !string.IsNullOrWhiteSpace(inputs[i]))
            {
                shortStrings[count] = inputs[i];
                count++;
            }
            else
            {
                shortStrings = [];
            }
        }

        return shortStrings;
    }

