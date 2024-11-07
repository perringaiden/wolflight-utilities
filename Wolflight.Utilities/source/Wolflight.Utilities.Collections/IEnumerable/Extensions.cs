namespace Wolflight.Utilities.Collections.IEnumerable
{
    /// <summary>
    /// Extensions for <see cref="IEnumerable{T}"/> and it's simple collection descendants.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns whether a given <see cref="IEnumerable{T}"/> is empty or <see langword="null"/>.
        /// </summary>
        /// <typeparam name="T">The type of the items in the <paramref name="collection"/>.</typeparam>
        /// <param name="collection">The collection of items.</param>
        /// <returns>True if the <paramref name="collection"/> is empty or <see langword="null"/>.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            return (collection is null) || (!collection.Any());
        }

        /// <summary>
        /// Returns whether a given <see cref="IEnumerable{T}"/> has values.
        /// </summary>
        /// <typeparam name="T">The type of the items in the <paramref name="collection"/>.</typeparam>
        /// <param name="collection">The collection of items.</param>
        /// <returns>True if the <paramref name="collection"/> exists and has at least one value.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> collection)
        {
            return (collection is not null) && (collection.Any());
        }

        /// <summary>
        /// Returns whether a given <see cref="ICollection{T}{T}"/> is empty or <see langword="null"/>.
        /// </summary>
        /// <typeparam name="T">The type of the items in the <paramref name="collection"/>.</typeparam>
        /// <param name="collection">The collection of items.</param>
        /// <returns>True if the <paramref name="collection"/> is empty or <see langword="null"/>.</returns>
        public static bool IsEmpty<T>(this ICollection<T> collection)
        {
            return (collection is null) || (collection.Count == 0);
        }

        /// <summary>
        /// Returns whether a given <see cref="IEnumerable{T}"/> has values.
        /// </summary>
        /// <typeparam name="T">The type of the items in the <paramref name="collection"/>.</typeparam>
        /// <param name="collection">The collection of items.</param>
        /// <returns>True if the <paramref name="collection"/> exists and has at least one value.</returns>
        public static bool IsNotEmpty<T>(this ICollection<T> collection)
        {
            return (collection is not null) && (collection.Count > 0);
        }

        /// <summary>
        /// Returns the values in a collection as comma separated values.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="values">The values to return.</param>
        /// <returns>A string of comma separated values, escaped if necessary.</returns>
        /// <remarks>The <typeparamref name="T"/> must override <see cref="Object.ToString"/>.</remarks>
        public static string ToCsv<T>(this IEnumerable<T> values)
        {
            // TODO: Escape this string so that it's not malformed.
            return string.Join(", ", values.Select((x) => x?.ToString()));
        }
    }
}
