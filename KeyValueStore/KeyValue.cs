using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{

    public struct KeyValue<T>
    {
        public string Key { get; }
        public T Value { get; }

        public KeyValue(string updateKey, T updateObject)
        {
            Key = updateKey;
            Value = updateObject;
        }

    }
}
