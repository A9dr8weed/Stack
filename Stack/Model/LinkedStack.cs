using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack.Model
{
    /// <summary>
    /// Stack based on a single-linked list.
    /// </summary>
    /// <typeparam name="T"> The type of data stored on the stack. </typeparam>
    public class LinkedStack<T> : IEnumerable<T>
    {
        /// <summary>
        /// The first item in the list.
        /// </summary>
        private Item<T> Head;

        /// <summary>
        /// Number of items in the list.
        /// </summary>
        private int count;

        /// <summary>
        /// Number of items in the list.
        /// </summary>
        public int Count => count;

        /// <summary>
        /// Create an empty list.
        /// </summary>
        public LinkedStack() => Clear();

        /// <summary>
        /// Clear list.
        /// </summary>
        public void Clear()
        {
            Head = null;
            count = 0;
        }

        /// <summary>
        /// Add data to the stack.
        /// </summary>
        /// <param name="data"> Added data. </param>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is <c>null</c>.</exception>
        public void Push(T data)
        {
            // Check input data for emptiness.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // The new element becomes the first.
            Head = new Item<T>(data)
            {
                // Reset the top of the stack to a new item.
                Next = Head
            };

            count++;
        }

        /// <summary>
        /// Get the top of the stack and remove.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Pop()
        {
            if (count == 0)
            {
                throw new NullReferenceException("Stack is empty.");
            }

            Item<T> item = Head;

            // reset the top of the stack to a new item
            Head = Head.Next;
            count--;

            return item.Data;
        }

        /// <summary>
        /// Read the top element of the stack without removing.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Peek()
        {
            if (count == 0)
            {
                throw new NullReferenceException("Stack is empty");
            }

            return Head.Data;
        }

        /// <summary>
        /// Check for element.
        /// </summary>
        /// <param name="data"> Data to be checked </param>
        /// <returns> String with message </returns>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is <c>null</c>.</exception>
        public string Contains(T data)
        {
            // Check input data for emptiness.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Item<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return $"Element {data} is in the list.";
                }
                current = current.Next;
            }

            return $"Element {data} is not in the list.";
        }

        /// <summary>
        /// Return an enumerator that iterates through the list.
        /// </summary>
        /// <returns> The IEnumerator used to traverse the collection. </returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Item<T> current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// To iterate over elements from the end.
        /// </summary>
        /// <returns> An enumerator that can be used to iterate over the collection. </returns>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    }
}