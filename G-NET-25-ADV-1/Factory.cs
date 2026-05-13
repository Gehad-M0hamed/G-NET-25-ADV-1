using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    internal class Factory<T> where T : new()
    {
        public T Create()
        { 
          return new T();
        }
    }
}
