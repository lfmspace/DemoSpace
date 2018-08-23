using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GOF.Struct.Adapter
{
    public class HttpCacheAdapter : ICacheStorage
    {
        private HttpContext context = null;
        public HttpCacheAdapter(HttpContext c)
        {
            context = HttpContext.Current;
        }

        public bool Add(string key, object obj)
        {
            context.Cache.Insert(key, obj);
            return true;
        }

        public T Get<T>(string key)
        {
            var obj = context.Cache.Get(key);
            return (T)obj;
        }

        public bool Remove(string key)
        {
            context.Cache.Remove(key);
            return true;
        }
    }
}
