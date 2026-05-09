using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    public class Container<T>
    {
        public T[] _items = new T[10];
        public int _count = 0;
        public void Add(T item)
        {
           if (_count < _items.Length)
           {
              _items[_count++] = item;
           }
        }
        public T Get(int index)
        {
            return _items[index];
        }

    }
}
