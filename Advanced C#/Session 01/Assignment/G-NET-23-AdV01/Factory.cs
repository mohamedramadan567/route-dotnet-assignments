using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01
{
    internal class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }

        public List<T> CreateMany(int count)
        {
            List<T> list = new();
            for(int i = 0; i < count; i++)
            {
                list.Add(new T());
            }
            return list;
        }
    }

    internal class UserTest
    {
        public string Name { get; set; } = "";
    }
}

