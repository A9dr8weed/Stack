using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    /// <summary>
    /// Stack
    /// </summary>
    /// <typeparam name="T"> The type of data stored on the stack. </typeparam>
    public class EasyStack<T> : ICloneable
    {
        /// <summary>
        /// The collection of stored data.
        /// </summary>
        private List<T> items = new List<T>();

        /// <summary>
        /// Amount of elements.
        /// </summary>
        public int Count => items.Count;

        /// <summary>
        /// Add data to the stack.
        /// </summary>
        /// <param name="item"> Added data. </param>
        /// <exception cref="ArgumentNullException"><paramref name="item"/> is <c>null</c>.</exception>
        public void Push(T item)
        {
            // Check input data for emptiness.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Add data to the collection of items.
            items.Add(item);
        }

        /// <summary>
        /// Clears the stack.
        /// </summary>
        public void Clear()
        {
            items.Clear();
        }

        /// <summary>
        /// Get the top of the stack and remove.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Pop()
        {
            // Get the top item.
            T item = items.LastOrDefault();

            // If the element is empty, then we report an error.
            if (item == null)
            {
                throw new NullReferenceException("The stack is empty. No items to receive.");
            }

            // Remove the last item from the collection.
            items.RemoveAt(items.Count - 1);

            // We return the resulting element.
            return item;
        }

        /// <summary>
        /// Read the top element of the stack without removing.
        /// </summary>
        /// <returns> Data item. </returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Peek()
        {
            // Get the top item.
            T item = items.LastOrDefault();

            // If the element is empty, then we report an error.
            if (item == null)
            {
                throw new NullReferenceException("The stack is empty. There are no items to receive.");
            }

            return item;
        }

        /// <summary>
        /// Casting an object to a string.
        /// </summary>
        /// <returns> Stored data. </returns>
        public override string ToString()
        {
            return $"Stack with {Count} elements.";
        }

        /// <summary>
        /// Creates a copy of an existing object.
        /// </summary>
        /// <returns> A copy of the current object. </returns>
        public object Clone()
        {
            return new EasyStack<T>
            {
                items = new List<T>(items)
            };
        }
    }
}