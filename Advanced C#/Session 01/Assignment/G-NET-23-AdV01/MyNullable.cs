using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class MyNullable<T> where T : struct
    {
        private readonly bool _hasValue;
        private readonly T _value;

        public bool HasValue => _hasValue;
        public T Value => _hasValue ? _value : throw new InvalidOperationException();

        public MyNullable(T value)
        {
            _hasValue = true;
            _value = value;
        }
    }
}
