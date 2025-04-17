using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class PathFinder
    {
        private readonly int[,] _grid;
        private readonly int _size;

        public PathFinder(int[,] grid)
        {
            _grid = grid;
            _size = grid.GetLength(0);
        }

        public (int sum, List<(int, int)> path) FindMinPath()
        {
            // Матрица для хранения минимальных сумм
            int[,] dist = new int[_size, _size];
            // Матрица для хранения предыдущих клеток
            (int, int)[,] prev = new (int, int)[_size, _size];
            // Матрица посещенных клеток
            bool[,] visited = new bool[_size, _size];

            // Инициализация
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    dist[i, j] = int.MaxValue;
                    prev[i, j] = (-1, -1);
                }
            }
            dist[0, 0] = _grid[0, 0];

            // Приоритетная очередь для выбора следующей клетки
            var priorityQueue = new PriorityQueue<(int, int), int>();
            priorityQueue.Enqueue((0, 0), dist[0, 0]);

            // Все возможные направления движения (8 соседей)
            (int, int)[] directions = {
            (-1, -1), (-1, 0), (-1, 1),
            (0, -1),           (0, 1),
            (1, -1),  (1, 0),  (1, 1)
        };

            while (priorityQueue.Count > 0)
            {
                var (x, y) = priorityQueue.Dequeue();

                if (visited[x, y]) continue;
                visited[x, y] = true;

                // Если достигли конечной точки
                if (x == _size - 1 && y == _size - 1)
                    break;

                // Проверяем всех соседей
                foreach (var (dx, dy) in directions)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < _size && ny >= 0 && ny < _size)
                    {
                        int newDist = dist[x, y] + _grid[nx, ny];

                        if (newDist < dist[nx, ny])
                        {
                            dist[nx, ny] = newDist;
                            prev[nx, ny] = (x, y);
                            priorityQueue.Enqueue((nx, ny), newDist);
                        }
                    }
                }
            }

            // Восстанавливаем путь
            var path = new List<(int, int)>();
            (int cx, int cy) = (_size - 1, _size - 1);

            while (cx != -1 && cy != -1)
            {
                path.Add((cx, cy));
                (cx, cy) = prev[cx, cy];
            }

            path.Reverse();

            return (dist[_size - 1, _size - 1], path);
        }
    }
}
