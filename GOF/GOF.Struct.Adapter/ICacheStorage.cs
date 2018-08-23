using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Struct.Adapter
{
    /// <summary>
    /// 缓存仓库，该接口被外部程序依赖或组成外部程序
    /// </summary>
    public interface ICacheStorage
    {
        bool Remove(string key);
        bool Add(string key,object obj);
        T Get<T>(string key);
    }
}
