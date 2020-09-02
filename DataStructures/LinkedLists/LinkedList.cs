using System.Collections;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    public class LinkedList : IEnumerable<int>
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Head = new Node
            {
                Value = value,
                Next = Head,
            };
        }

        public bool Includes(int value)
        {
            // TODO
            return false;
        }

        public override string ToString()
        {
            string result = "";

            Node current = Head;
            while (current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }

            return result + "NULL";
        }

        public IEnumerator<int> GetEnumerator()
        {
            Node current = Head;
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