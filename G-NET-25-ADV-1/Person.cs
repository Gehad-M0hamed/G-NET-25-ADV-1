using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Name = "Gody";
            Age = 21;
        }
        public override string ToString() => $"Name:{Name}::Age:{Age}";


    }
}
