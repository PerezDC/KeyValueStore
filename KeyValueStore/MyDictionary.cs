using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public class MyDictionary<T>
    {
        private KeyValue<T>[] _keyValueArray = new KeyValue<T>[10];
        private int _tracker = 0;
        
        public T this[string key]
        {
            get
            {
                for (int i = 0; i < _keyValueArray.Length; i++)
                {
                    if ((string)_keyValueArray[i].Key == key)
                    {
                        return _keyValueArray[i].Value;
                    }
                }
                throw new KeyNotFoundException(key);
            }
            set
            {
                for (int i = 0; i < _keyValueArray.Length; i++)
                {
                    if ((string)_keyValueArray[i].Key == key)
                    {
                        _keyValueArray[i] = new KeyValue<T>(key, value);
                        return;
                    }
                    else if ((string)_keyValueArray[i].Key == null)
                    {
                        _keyValueArray[i] = new KeyValue<T>(key, value);
                        _tracker++;
                        return;
                    }
                }
            }
        }
    }
}
