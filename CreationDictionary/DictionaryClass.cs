using System;
using System.Collections.Generic;
using System.Text;

namespace CreationDictionary
{
    class DictionaryClass<K, V>
    {
        KeyValuePair<K, V>[] items;

        public DictionaryClass()
        {
            items = new KeyValuePair<K, V>[0];
        }

        public void Add(K key, V value)
        {
            KeyValuePair<K, V>[] tempArray = items;
            items = new KeyValuePair<K, V>[tempArray.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }
            items[items.Length - 1] = new KeyValuePair<K, V>(key, value);
        }
        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " --> " + item.Value);
            }
            
        }
    }
}
