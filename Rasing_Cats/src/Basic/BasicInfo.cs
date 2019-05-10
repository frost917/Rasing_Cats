using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasing_Cats
{
    [Serializable()]
    class BasicInfo
    {
        string name;
        int age;
        double weight;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
