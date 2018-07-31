using System;
using System.Collections.Generic;
using System.Text;

namespace VSFeatures.Tests
{
    public class Comparer
    {
        public static Comparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new Comparer<U>(func);
        }
    }

    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> myComparer;

        public Comparer(Func<T, T, bool> func)
        {
            myComparer = func;
        }

        public bool Equals(T x, T y)
        {
            return myComparer(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
