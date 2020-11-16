using System.Collections.Generic;

namespace Generics
{
    internal class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}