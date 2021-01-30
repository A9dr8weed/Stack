﻿using System;

namespace Stack.Model
{
    /// <summary>
    /// The class describing the linked list item.
    /// </summary>
    public class Item<T>
    {
        /// <summary>
        /// Stored data.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Previous cell in the list.
        /// </summary>
        public Item<T> Previous { get; set; }

        /// <summary>
        /// Creation of a new instance of the linked list.
        /// </summary>
        /// <param name="data"> Stored data. </param>
        public Item(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        /// <summary>
        /// Casting an object to a string.
        /// </summary>
        /// <returns> Stored data. </returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}