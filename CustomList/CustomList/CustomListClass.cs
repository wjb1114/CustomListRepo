using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] vals;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private int ArrayLength
        {
            get
            {
                return vals.Length;
            }
        }

        public T this[int indexer]
        {
            get
            {
                return vals[indexer];
            }
            set
            {
                vals[indexer] = value;
            }
        }

        public CustomList()
        {
            vals = new T[4];
            count = 0;
        }

        public void Add(T item)
        {
            if (Count >= ArrayLength)
            {
                UpdateArrayLength(ArrayLength * 2);
            }
            vals[Count] = item;
            count++;
        }

        private void UpdateArrayLength(int length)
        {
            T[] oldVals = new T[vals.Length];
            for (int i = 0; i < vals.Length; i++)
            {
                oldVals[i] = vals[i];
            }
            vals = new T[length];
            for (int i = 0; i < oldVals.Length; i++)
            {
                vals[i] = oldVals[i];
            }
        }
    }
}
