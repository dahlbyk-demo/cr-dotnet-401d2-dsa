﻿namespace DataStructures.LinkedLists
{
    public class LinkedList
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
            // TODO
            return "NULL";
        }
    }
}
