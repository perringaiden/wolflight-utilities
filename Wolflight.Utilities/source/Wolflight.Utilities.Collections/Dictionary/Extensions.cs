namespace Wolflight.Utilities.Collections.Dictionary
{
    /// <summary>
    /// Extensions for <see cref="IDictionary{TKey, TValue}"/> and similar collections.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Adds a value to an <see cref="ISet{TValue}<"/> stored against a key.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the values in the set.</typeparam>
        /// <param name="dictionary">The dictionary to add a value to.</param>
        /// <param name="key">The key of the set.</param>
        /// <param name="value">The value to add.</param>
        public static void AddSetValue<TKey, TValue>(this IDictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {

            if (!dictionary.TryGetValue(key, out ISet<TValue>? values))
            {
                values = new HashSet<TValue>();
                dictionary.Add(key, values);
            }

            values.Add(value);
        }
    }
}
