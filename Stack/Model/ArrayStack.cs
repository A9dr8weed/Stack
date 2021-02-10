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
        private T[] items;

        /// <summary>
        /// Number of elements.
        /// </summary>
        private int count;

        /// <summary>
        /// Number of elements.
        /// </summary>
        public int Count => count;

        /// <summary>
        /// Initialization with the specified size.
        /// </summary>
        /// <param name="size"> Array size, default size = 10. </param>
        public ArrayStack(int size = 10)
        {
            items = new T[size];
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

            // Increase the stack. 
            if (count == items.Length)
            {
                Resize(items.Length + 10);
            }

            // Add an element to the array, while increasing the value of the count variable.
            items[count++] = data;
        }

        /// <summary>
        /// Get the top of the stack and remove.
        /// </summary>
        /// <returns> Data item. </returns>
        public T Pop()
        {
            // Pop an element from the top of the stack, decreasing the value of the variable count.
            T item = items[--count];
            // Reset the link.
            items[count] = default;

            // If there are more than 10 empty cells in the items array.
            if (count > 0 && count < items.Length - 10)
            {
                Resize(items.Length - 10);
            }

            return item;
        }

        /// <summary>
        /// Read the top element of the stack without removing.
        /// </summary>
        /// <returns> Data item. </returns>
        public T Peek()
        {
            return items[count - 1];
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

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(data))
                {
                    return $"Element {data} is in the list.";
                }
            }

            return $"Element {data} is not in the list.";
        }

        /// <summary>
        /// Resizes the array to max.
        /// </summary>
        /// <param name="max"> The size. </param>
        private void Resize(int max)
        {
            // Method creates a new array.
            T[] tempItems = new T[max];

            for (int i = 0; i < count; i++)
            {
                // Data is copied from the old.
                tempItems[i] = items[i];
            }

            items = tempItems;
        }
    }
}