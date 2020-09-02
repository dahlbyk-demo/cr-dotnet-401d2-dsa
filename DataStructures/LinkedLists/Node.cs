namespace DataStructures.LinkedLists
{
    public class Node<T>
    {
        /// <summary>
        /// Value of this node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Pointer to the next node in the list.
        /// </summary>
        public Node<T> Next { get; set; }
    }
}