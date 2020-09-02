using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public void Insert(T value)
        {
            Head = new Node<T>
            {
                Value = value,
                Next = Head,
            };
        }

        public bool Includes(T value)
        {
            // TODO
            return false;
        }

        public override string ToString()
        {
            string result = "";

            Node<T> current = Head;
            while (current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }

            return result + "NULL";
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                // Include this value in the sequence
                yield return current.Value;

                current = current.Next;
            }

            // This says we're done, but usually not needed
            // yield break;
        }

        // Explicit interface implementation
        // Makes non-generic implementation happy
        // You don't need to understand why
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}