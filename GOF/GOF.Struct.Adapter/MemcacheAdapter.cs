using Enyim.Caching;
using Enyim.Caching.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Struct.Adapter
{
    public class MemcacheAdapter : ICacheStorage
    {
        private IMemcachedClient mc = null;
        public MemcacheAdapter()
        {
            mc = new MemcachedClient();
        }

        public bool Add(string key, object obj)
        {
            return mc.Store(StoreMode.Add, key, obj);
        }

        public T Get<T>(string key)
        {
            return mc.Get<T>(key);
        }

        public bool Remove(string key)
        {
            return mc.Remove(key);
        }
    }
}
