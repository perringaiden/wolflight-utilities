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
        public static void AddSetValue<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {
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
        public static void AddSetValues<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key, IEnumerable<TValue> values)
        {
            GetValues(dictionary, key).UnionWith(values);
        }

        /// <summary>
        /// Removes a value to an <see cref="ISet{TValue}"/> stored against a key, and returns whether the item was in the set.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to remove a value from.</param>
        /// <param name="key">The key of the set.</param>
        /// <param name="value">The value to remove.</param>
        /// <returns>
        ///	 True if the value was removed from the set, otherwise false if the value was not found or the key did not exist.
        /// </returns>
        public static bool RemoveSetValue<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {
            if (!dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                if (items != null)
                {
                    return items.Remove(value);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets a set from a dictionary, stored against a key, adding the set to the dictionary if it does not exist.
        /// <summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to remove a value from.</param>
        /// <param name="key">The key of the set.</param>
        /// <returns>The set stored against the key.
        public static ISet<TValue> GetValues<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key)
        {
            if (!dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                items = new HashSet<TValue>();
                dictionary.Add(key, items);
            }

            return items;
        }

        public static bool HasValue<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {
            if (dictionary.TryGetValue(key, out ISet<TValue>? items))
            {
                return (items != null) && (items.Contains(value));
            }

            return false;
        }
    }
}
