using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    internal class ComparableHelper
    {
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }

        public static T FindMin<T>(T[] items) where T : IComparable<T>
        {
            T min = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }
            return min;
        }
        
    }
}
