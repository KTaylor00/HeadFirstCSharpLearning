using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClowns
{
    internal interface IClown
    {
        string FunnyThingIHave { get; }

        void Honk();
    }
}
