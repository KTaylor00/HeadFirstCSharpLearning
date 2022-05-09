using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPoolPuzzle
{
    internal class Q
    {
        public static Random Random = new Random();
        public int N1 { get; private set; }
        public string Op { get; private set; }
        public int N2 { get; private set; }

        public Q(bool add)
        {
            if (add)
                Op = "+";
            else
                Op = "*";
            N1 = Random.Next(1, 10);
            N2 = Random.Next(1, 10);
        }

        public bool Check(int a)
        {
            if (Op == "+")
                return (a == N1 + N2);
            else
                return (a == N2 * N1);
        }
    }
}
