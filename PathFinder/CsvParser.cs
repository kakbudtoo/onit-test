using System;
using System.IO;

namespace PathFinder
{
    // Реализация парсера CSV файла.
    public class CsvParser
    {
        public int[,] ParseCsv(string filePath)
        {
            const int size = 20;
            int[,] result = new int[size, size];

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length != size)
                throw new ArgumentException($"CSV файл должен содержать ровно {size} строк");

            for (int i = 0; i < size; i++)
            {
                string[] elements = lines[i].Split(',');

                if (elements.Length != size)
                    throw new FormatException($"Строка {i + 1}: найдено {elements.Length} элементов вместо {size}");

                for (int j = 0; j < size; j++)
                {
                    int.TryParse(elements[j], out int var);
                    if (!int.TryParse(elements[j], out var))
                    {
                        Console.WriteLine($"Ошибка: Невозможно преобразовать '{elements[j]}' в int.");
                    }
                    result[i, j] = var;
                }
            }

            return result;
        }
    }
}
