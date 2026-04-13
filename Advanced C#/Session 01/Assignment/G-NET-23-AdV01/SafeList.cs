using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class SafeList<T>
    {
        private List<T> _items = new();

        public void Add(T item) => _items.Add(item); 

        public T? GetAt(int index)
        {
            if (index >= 0 && index < _items.Count)
                return _items[index];
            return default(T);
        }

    }
}
