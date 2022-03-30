﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection_Task
{
    internal class BasketList<T>
    {
        public T[] Arr;

        public BasketList()
        {
            Arr = new T[0];
        }

        public T[] GetArray()
        {
            return Arr;
        }
        public void AddItem(T vit)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = vit;
        }
    }
}
