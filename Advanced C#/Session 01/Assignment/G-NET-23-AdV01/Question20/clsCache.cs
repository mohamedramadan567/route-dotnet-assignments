using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01.Question20
{
    internal class clsCache<TKey, TValue>
    {
        private Dictionary<TKey, CacheItem<TValue>> _cache = new();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            _cache[key] = new CacheItem<TValue>(value, duration);
        }

        public TValue Get(TKey key)
        {
            if(_cache.ContainsKey(key) && !_cache[key].IsExpired())
                return _cache[key].Value;
            return default;
        }

        public bool Remove(TKey key)
        {
            if(_cache.ContainsKey(key))
            {
                _cache.Remove(key);
                return true;
            }
            return false;
        }

        public bool Contains(TKey key)
        {
            return _cache.ContainsKey(key) && !_cache[key].IsExpired();
        }




    }
}
