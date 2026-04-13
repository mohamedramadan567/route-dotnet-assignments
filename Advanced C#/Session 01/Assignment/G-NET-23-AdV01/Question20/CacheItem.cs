using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01.Question20
{
    internal class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime ExpirationTime  { get; set; }
        public CacheItem(TValue value, TimeSpan duration)
        {
            Value = value;
            ExpirationTime = DateTime.Now.Add(duration);
        }
        public bool IsExpired() => DateTime.Now > ExpirationTime;
    }
}
