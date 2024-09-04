using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{

    
// Hash Table Summary
// 
// A hash table is a data structure used to store key-value pairs.
// It provides fast access to values based on their keys using a process called hashing.
// 
// Key Concepts:
// 1. **Buckets**: The hash table contains an array of "buckets." Each bucket can store multiple entries that have the same hash code.
// 2. **Hash Function**: A hash function maps the key to a specific bucket index using the key's hash code.
// 3. **Collisions**: When two keys hash to the same bucket, a collision occurs. 
//    These collisions are resolved using separate chaining, where each bucket holds a linked list of key-value pairs.
// 4. **Operations**:
//    - **Add(K key, V value)**: Adds or updates a key-value pair in the hash table. Handles collisions by adding to the linked list in the bucket.
//    - **Get(K key)**: Retrieves the value associated with the key. If the key is not found, it throws a KeyNotFoundException.
//    - **Remove(K key)**: Removes the key-value pair from the table. If the key is not found, it throws a KeyNotFoundException.
// 
// Benefits:
// - Fast average time complexity (O(1)) for lookup, insertion, and deletion.
// - Efficiently handles large datasets.
//
// Limitations:
// - Performance depends on a good hash function to minimize collisions.
// - Space overhead due to the use of extra memory (linked lists) for collision resolution.

    public class CustomHashTable<K, V>
    {
        public class HashNode
        {
            public K Key;
            public V Value;
            public HashNode Next { get; set; }

            public HashNode(K key, V value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
           
        }
        private HashNode[] _buckets;

        public CustomHashTable(int size)
        {
            _buckets = new HashNode[size];
        }
        
        private int GetBucketIndex(K key)
        {
            int hashCode = key.GetHashCode();
            return Math.Abs(hashCode % _buckets.Length);
        }

        public void Add(K key, V value)
        {
            int index = GetBucketIndex(key);
            HashNode node = _buckets[index];

            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    node.Value = value;
                    return;
                }
                node = node.Next;
            }

            node = new HashNode(key, value);
            node.Next = _buckets[index];
            _buckets[index] = node;
        }

        public V Get(K key)
        {
            int index = GetBucketIndex(key);
            HashNode node = _buckets[index];

            while (node != null)
            {
                if (node.Key.Equals(key))
                {

                      return node.Value;
                }
                node = node.Next;
            }
            throw new KeyNotFoundException($"Key '{key}' not found.");
        }

        public void Remove(K key)
        {
            int index = GetBucketIndex(key);
            HashNode node = _buckets[index];
            HashNode previous = null;

            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    if (previous == null)
                    {
                        _buckets[index] = node.Next;
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                    return;
                }
                previous = node;
                node = node.Next;
            }
            throw new KeyNotFoundException($"Key '{key}' not found.");
        }
    }

}




