using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Container<T>
    {
        private readonly T[] _container;
        private int _index;
        public Container(int Capacity)
        {
            _index = 0;
            if (Capacity > 0)
                _container = new T[Capacity];
        }

        public void Add(T item)
        {
            if(_index <  _container.Length) 
                _container[_index++] = item;
        }

        public T Get(int index)
        {
            if(index < _container.Length && index >= 0)
                return _container[index];
            return default(T);
        }


    }
}
