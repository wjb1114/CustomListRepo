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

        public int Count { get; private set; }

        public int Capacity
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
                if(indexer >= Count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                else
                {
                    return vals[indexer];
                }
            }
            set
            {
                vals[indexer] = value;
            }
        }

        public CustomList()
        {
            vals = new T[4];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                UpdateArrayLength(Capacity * 2);
            }
            vals[Count] = item;
            Count++;
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
