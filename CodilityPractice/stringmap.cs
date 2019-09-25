using System;
using System.Collections.Generic;

namespace CodilityPractice
{
    public class stringmap<TValue>
    {
        Dictionary<string, TValue> stringElements = new Dictionary<string, TValue>();
        public int count => stringElements.Count;
        public stringmap()
        {
        }
        public bool AddElement(string key, TValue value)
        {
            if (key == null || value == null)
            {
                throw new System.ArgumentNullException();
            }
            else if (key == string.Empty)
            {
                throw new System.ArgumentException();

            }
            else if (stringElements.ContainsKey(key))
            {
                stringElements[key] = value;
                return true;
            }
            else
            {
                stringElements.Add(key, value);
                return false;
            }
            
        }
        public bool RemoveElement(string key)
        {
            if (key == null)
            {
                throw new System.ArgumentNullException();
            }
            else if (key == string.Empty)
            {
                throw new System.ArgumentException();
            }
            else if (stringElements.ContainsKey(key))
            {
                stringElements.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            else if (key == string.Empty)
            {
                throw new ArgumentException();
            }
            if (stringElements.ContainsKey(key))
            {
                return stringElements[key];
            }
            else
            {
                return DefaultValue;
            }
        }
        public TValue DefaultValue
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}


/*namespace CustomCollection.Tests
{
    // Do not change the name of this class
    public class StringMap<TValue> : IStringMap<TValue>
        where TValue : class
    {
        /// <summary> Returns number of elements in a map</summary>
        public int Count => throw new NotImplementedException();

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        public TValue DefaultValue
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in a map, then the value associated with this key should be overriden.
        /// </summary>
        /// <returns>true if the value for the key was overriden otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        public bool AddElement(string key, TValue value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        public bool RemoveElement(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            throw new NotImplementedException();
        }
    }
}
*/
