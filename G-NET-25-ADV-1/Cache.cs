using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    internal class Cache<T> where T : class
    {
        private T? _cachedItem;

        public T? Get() => _cachedItem;

        public void Set(T item)
        {
            _cachedItem = item;
        }

        public void Clear()
        {
            _cachedItem = null; 
        }

        public bool IsSame(T other)
        {
            return ReferenceEquals(_cachedItem, other);
        }

    }
}
