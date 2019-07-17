﻿using System;
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
        public CustomList(T[] initialValues)
        {
            vals = new T[4];
            Count = 0;
            for (int i = 0; i < initialValues.Length; i++)
            {
                Add(initialValues[i]);
            }
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

        public bool Remove(T item)
        {
            if (Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(vals[i], item))
                    {
                        RemoveItemAtIndex(i);
                        Count--;
                        return true;
                    }
                }
                return false;
            }
        }

        public override string ToString()
        {
            string listStringOutput = "";
            for (int i = 0; i < Count; i++)
            {
                if (listStringOutput.Length > 0)
                {
                    listStringOutput += ", ";
                }
                listStringOutput += vals[i];
            }
            return listStringOutput;
        }

        private void UpdateArrayLength(int length)
        {
            T[] oldVals = new T[Capacity];
            for (int i = 0; i < Capacity; i++)
            {
                oldVals[i] = vals[i];
            }
            vals = new T[length];
            for (int i = 0; i < oldVals.Length; i++)
            {
                vals[i] = oldVals[i];
            }
        }

        private void RemoveItemAtIndex(int index)
        {
            T[] oldVals = new T[Capacity];
            for (int i = 0; i < index; i++)
            {
                oldVals[i] = vals[i]; 
            }
            for (int i = (index + 1); i < Count; i++)
            {
                oldVals[i - 1] = vals[i];
            }
            vals = new T[Capacity];
            for (int i = 0; i < Count; i++)
            {
                vals[i] = oldVals[i];
            }
        }
    }
}
