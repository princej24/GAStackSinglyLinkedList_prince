using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAStackSinglyLinkedList_prince
{
    class Stack<T>
    {
        // Nested class StackNode representing elements in the stack.
        class StackNode
        {
            public T Value { get; set; }                    // Data stored in the node.
            public StackNode Next { get; set; }             // Reference to the next node.

            public StackNode(T value)
            {
                Value = value;
                Next = null;
            }
        }

        // Private field to track the top element of the stack.
        private StackNode top;
        private int count;

        // Public property to access the count of elements.
        public int Count
        {
            get { return count; }
        }

        // Constructor to initialize an empty stack.
        public Stack()
        {
            top = null;
            count = 0;
        }

        // Push method to add a new element to the top of the stack.
        public void Push(T value)
        {
            StackNode newNode = new StackNode(value);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        // Pop method to remove and return the top element from the stack.
        public T Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            T value = top.Value;
            top = top.Next;
            count--;
            return value;
        }

        // Peek method to return the value of the top element without removing it.
        public T Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            return top.Value;
        }

        // Clear method to remove all elements from the stack.
        public void Clear()
        {
            top = null;
            count = 0;
        }
    }
}
