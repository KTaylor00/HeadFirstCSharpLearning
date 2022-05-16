using System;
using System.Collections.Generic;

namespace ConsoleAppDucks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Loon, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Loon, Size = 13},
            };
            // Sorts the ducks by Size.
            /*IComparer<Duck> sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);*/

            // Sorts the ducks by Kind.
            /*IComparer<Duck> kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);*/

            // Looks at the public SortBy field to determine how to sort the ducks in the DuckComparer class.
            DuckComparer comparer = new DuckComparer();

            Console.WriteLine("\nSorting by kind then size\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.WriteLine("\nSorting by size then kind\n");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            ducks.GetEnumerator();


        }

        public static void PrintDucks(List<Duck> ducks)
        {
            /*foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }*/

            // This is what the above code is doing behind the scenes(some of the code)
            IEnumerator<Duck> enumerator = ducks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Duck duck = enumerator.Current;
                Console.WriteLine(duck);
            }
            if (enumerator is IDisposable disposable)
                disposable.Dispose();
        }
    }
}
