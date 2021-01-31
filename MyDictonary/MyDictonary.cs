using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictonary<TKey, TValue>
    {
        TKey[] Tkeys;
        TValue[] Tvalues;
        public MyDictonary()
        {
            Tkeys = new TKey[0];
            Tvalues = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = Tkeys;
            TValue[] tempValue = Tvalues;
            Tkeys = new TKey[tempKey.Length + 1];
            Tvalues = new TValue[tempValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                Tkeys[i] = tempKey[i];
                Tvalues[i] = tempValue[i];
            }
            Tkeys[Tkeys.Length - 1] = key;
            Tvalues[Tvalues.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < Tkeys.Length; i++)
            {
                Console.WriteLine(Tkeys[i] + " " + Tvalues[i]);
            }
        }
    }

}
