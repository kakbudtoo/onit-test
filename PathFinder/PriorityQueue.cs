using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    // Простая реализация PriorityQueue для .NET < 6
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable<TPriority>
    {
        private readonly List<(TElement, TPriority)> _elements = new List<(TElement, TPriority)>();

        public int Count => _elements.Count;

        public void Enqueue(TElement element, TPriority priority)
        {
            _elements.Add((element, priority));
            _elements.Sort((x, y) => x.Item2.CompareTo(y.Item2));
        }

        public TElement Dequeue()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            var item = _elements[0].Item1;
            _elements.RemoveAt(0);
            return item;
        }
    }
}
