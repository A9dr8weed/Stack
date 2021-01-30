using System;

namespace Stack.Model
{
    /// <summary>
    /// Array-based stack.
    /// </summary>
    /// <typeparam name="T"> The type of data stored on the stack. </typeparam>
    public class ArrayStack<T>
    {
        /// <summary>
        /// Array elements.
        /// </summary>
        private readonly T[] items;

        /// <summary>
        /// Maximum number of items.
        /// </summary>
        public int MaxCount => items.Length;

        /// <summary>
        /// Current item.
        /// </summary>
        private int current = -1;

        /// <summary>
        /// The first element of the array.
        /// </summary>
        public int Count => current + 1;

        /// <summary>
        /// Array size.
        /// </summary>
        private readonly int Size = 10;

        /// <summary>
        /// Initialization with the specified size.
        /// </summary>
        /// <param name="size"> Array size, default size = 10. </param>
        public ArrayStack(int size = 10)
        {
            Size = size;
            items = new T[size];
        }

        /// <summary>
        /// Add data to the stack.
        /// </summary>
        /// <param name="data"> Added data. </param>
        /// <exception cref="StackOverflowException"></exception>
        public void Push(T data)
        {
            if (current < Size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Stack is overflow");
            }
        }

        /// <summary>
        /// Get the top of the stack and remove.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Pop()
        {
            if (current >= 0)
            {
                T item = items[current];
                current--;

                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        /// <summary>
        /// Read the top element of the stack without removing.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}