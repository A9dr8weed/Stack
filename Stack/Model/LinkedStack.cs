using System;

namespace Stack.Model
{
    /// <summary>
    /// Stack based on a single-linked list.
    /// </summary>
    /// <typeparam name="T"> The type of data stored on the stack. </typeparam>
    public class LinkedStack<T>
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
                // reset the top of the stack to a new item
                Previous = Head
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
            if (count > 0)
            {
                Item<T> item = Head;

                // reset the top of the stack to a new item
                Head = Head.Previous;
                count--;

                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty.");
            }
        }

        /// <summary>
        /// Read the top element of the stack without removing.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Peek()
        {
            if (count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}