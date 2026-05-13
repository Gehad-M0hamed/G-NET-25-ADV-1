using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    internal class ValueContainer<T> where T :struct
    {
        public ValueContainer(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
    }
}
