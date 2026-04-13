using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_AdV01.Question12
{
    //Question12
    public class EntityManager<T> where T : class, IEntity, new()
    {
        public T CreateAndSave()
        {
            var entity = new T();      
            entity.Id = Guid.NewGuid();
            return entity;
        }
    }

    public class Mapper<TSource, TDest>
    where TSource : class
    where TDest : class, new()
    {
        public TDest Map(TSource source)
        {
            var dest = new TDest();
            return dest;
        }
    }
}
