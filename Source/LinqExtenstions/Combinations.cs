using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtenstions
{
    public static class Combinations
    {
        public static IEnumerable<IEnumerable<T>> Permutations<T>(this IEnumerable<T> source)
        {
            var sourceArray = source as T[] ?? source.ToArray();

            var count = sourceArray.Count();

            if (count == 1)
                yield return sourceArray;
            else
                for (var i = 0; i < count; i++)
                    foreach (var p in Permutations(sourceArray.Take(i).Concat(sourceArray.Skip(i + 1))))
                        yield return sourceArray.Skip(i).Take(1).Concat(p);
        }
    }
}
