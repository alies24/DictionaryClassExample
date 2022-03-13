using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryClass
{
    public class Dictionary<TKey, TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;
        TKey[] keyTempArrays;
        TValue[] valueTempArrays;
        public Dictionary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        
        }
        public void Add(TKey key, TValue value)
        {
            keyTempArrays = tkey;
            valueTempArrays = tvalue;

            tkey = new TKey[tkey.Length + 1];
            tvalue = new TValue[tvalue.Length + 1];

            for (int i = 0; i < keyTempArrays.Length; i++)
            {
                tkey[i] = keyTempArrays[i];
                tvalue[i] =valueTempArrays[i];
            }
            tkey[tkey.Length - 1] = key;
            tvalue[tvalue.Length - 1] = value;
        }
        public int Count { 
        
        get { return tkey.Length; } 
        }

    }
}
