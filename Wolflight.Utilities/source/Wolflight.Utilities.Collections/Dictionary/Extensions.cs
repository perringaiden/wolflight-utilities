namespace Wolflight.Utilities.Collections.Dictionary
{
    /// <summary>
    /// Extensions for <see cref="IDictionary{TKey, TValue}"/> and similar collections.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Adds a value to an <see cref="ISet{TValue}"/> stored against a key.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to add a value to.</param>
        /// <param name="key">The key of the set.</param>
        /// <param name="value">The value to add.</param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dictionary"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="value"/> was <see langword="null"/>.
        /// </exception>
        public static void AddSetValue<TKey, TValue>(
            this IDictionary<TKey, ISet<TValue>> dictionary,
            TKey key,
            TValue value
        )
        {
            ArgumentNullException.ThrowIfNull(value);

            GetValues(dictionary, key).Add(value);
        }

        /// <summary>
        /// Adds a set of values to <see cref="ISet{TValue}" stored against a key.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to add values to.</param>
        /// <param name="key">The key of the set.</param>
        /// <param name="values">The values to add.</param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dictionary"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="values"/> was <see langword="null"/>.
        /// </exception>
        public static void AddSetValues<TKey, TValue>(
            this IDictionary<TKey, ISet<TValue>> dictionary,
            TKey key,
            IEnumerable<TValue> values
        )
        {
            ArgumentNullException.ThrowIfNull(values);

            GetValues(dictionary, key).UnionWith(values);
        }

        /// <summary>
        /// Removes a value to an <see cref="ISet{TValue}"/> stored 
        /// against a key, and returns whether the item was in the set.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to remove a value from.</param>
        /// <param name="key">The key of the set.</param>
        /// <param name="value">The value to remove.</param>
        /// <returns>
        ///	 True if the value was removed from the set, otherwise False
        ///	 if the value was not found or the key did not exist.
        /// </returns>
        /// <remarks>If the last item from a set is removed, the set will also be removed.</remarks>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dictionary"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="value"/> was <see langword="null"/>.
        /// </exception>
        public static bool RemoveSetValue<TKey, TValue>(
            this IDictionary<TKey, ISet<TValue>> dictionary,
            TKey key,
            TValue value
        )
        {
            ArgumentNullException.ThrowIfNull(dictionary);
            ArgumentNullException.ThrowIfNull(key);
            ArgumentNullException.ThrowIfNull(value);

            bool rc = false;

            if (dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                if (items != null)
                {
                    rc = items.Remove(value);

                    if (items.Count == 0)
                    {
                        dictionary.Remove(key);
                    }
                }
            }

            return rc;
        }

        /// <summary>
        /// Gets a set from a dictionary, stored against a key, adding the set to the dictionary if it does not exist.
        /// <summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to get the values from.</param>
        /// <param name="key">The key of the set.</param>
        /// <returns>The set stored against the key.
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dictionary"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> was <see langword="null""/>.
        /// </exception>
        public static ISet<TValue> GetValues<TKey, TValue>(
            this IDictionary<TKey, ISet<TValue>> dictionary,
            TKey key
        )
        {
            ArgumentNullException.ThrowIfNull(dictionary);
            ArgumentNullException.ThrowIfNull(key);

            if (!dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                items = new HashSet<TValue>();
                dictionary.Add(key, items);
            }

            return items;
        }

        /// <summary>
        /// Returns True if a <paramref name="key"/> exists in the <paramref name="dictionary"/>
        /// containing the given <paramref name="value"/>, otherwise False.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to search for a value from.</param>
        /// <param name="key">The key of the set to check.</param>
        /// <param name="value">The value to search for</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dictionary"/> was <see langword="null""/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="key"/> was <see langword="null""/>.
        /// </exception>
        public static bool HasValue<TKey, TValue>(
            this IDictionary<TKey, ISet<TValue>> dictionary,
            TKey key,
            TValue value
        )
        {
            ArgumentNullException.ThrowIfNull(dictionary);
            ArgumentNullException.ThrowIfNull(key);

            if (dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                return (items != null) && (items.Contains(value));
            }

            return false;
        }
    }
}
