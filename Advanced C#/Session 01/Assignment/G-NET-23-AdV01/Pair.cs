using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Pair<TKey,  TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"({Key}, {Value})";
        }
    }
}
