using System;
using System.Collections.Generic;

namespace PathFinder
{
    

    // Пример использования
    public class Program
    {
        public static void Main()
        {
            // Создаем тестовую матрицу 20x20 со случайными значениями
            int[,] grid = new int[20, 20];
            var parser = new CsvParser();
            try
            {
                grid = parser.ParseCsv("data.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            var finder = new PathFinder(grid);
            var result = finder.FindMinPath();

            Console.WriteLine($"Minimal path sum: {result.sum}");
            Console.WriteLine("Path:");
            foreach (var (x, y) in result.path)
            {
                Console.WriteLine($"({x}, {y}) - {grid[x, y]}");
            }
        }
    }

    // Простая реализация PriorityQueue для .NET < 6

}
