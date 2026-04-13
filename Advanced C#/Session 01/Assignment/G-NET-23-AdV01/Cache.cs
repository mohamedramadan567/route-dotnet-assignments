using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Cache<T> where T : class
    {
        private T? _cachedItem;

        public T? Get => _cachedItem;
        public void Set(T? value)
        {
            _cachedItem = value;
        }
        public void Clear()
        {
            _cachedItem = null;
        }

        public bool IsSame(T otehr) => ReferenceEquals(_cachedItem, otehr);

    }
}
