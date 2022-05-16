using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBirdsCovariance
{
    internal class Duck : Bird
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public override string ToString() => $"{Size} inch {Kind}";
    }
}
