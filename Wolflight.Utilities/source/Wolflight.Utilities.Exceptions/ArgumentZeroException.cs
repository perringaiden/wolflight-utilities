using System.Runtime.CompilerServices;

namespace Wolflight.Utilities.Exceptions
{
    public class ArgumentZeroException : ArgumentException
    {

        private const string ArgumentZeroString = "The provided argument was zero.";
        private const string ArgumentZeroOrLessString = "The provided argument was zero or less.";

        /// <summary>
        /// Creates a new <see cref="ArgumentZeroException"/>.
        /// </summary>
        /// <param name="message">The message describing the </param>
        private ArgumentZeroException(string? message, string? paramName) : base(message, paramName) { }

        #region Integers

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        /// <exception cref="ArgumentZeroException">The argument was zero.</exception>
        public static void ThrowIfZero(
            int argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument == 0)
            {
                ThrowZeroException(paramName);
            }
        }

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero or less.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        public static void ThrowIfZeroOrLess(
            int argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument <= 0)
            {
                ThrowZeroOrLessException(paramName);
            }
        }

        #endregion

        #region Longs

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        /// <exception cref="ArgumentZeroException">The argument was zero.</exception>
        public static void ThrowIfZero(
            long argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument == 0L)
            {
                ThrowZeroException(paramName);
            }
        }

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero or less.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        public static void ThrowIfZeroOrLess(
            long argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument <= 0L)
            {
                ThrowZeroOrLessException(paramName);
            }
        }

        #endregion

        #region Decimal

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        /// <exception cref="ArgumentZeroException">The argument was zero.</exception>
        public static void ThrowIfZero(
            decimal argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument == 0M)
            {
                ThrowZeroException(paramName);
            }
        }

        /// <summary>
        /// Throws an exception if the provided <paramref name="argument"/> is zero or less.
        /// </summary>
        /// <param name="argument">The argument to evaluate.</param>
        /// <param name="paramName">The parameter name of the argument.</param>
        public static void ThrowIfZeroOrLess(
            decimal argument,
            [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument <= 0M)
            {
                ThrowZeroOrLessException(paramName);
            }
        }

        #endregion

        #region Exceptions

        /// <summary>
        /// Throws an exception for a zero parameter.
        /// </summary>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentZeroException">The argument was zero.</exception>
        private static void ThrowZeroException(string? paramName)
        {
            ArgumentNullException.ThrowIfNull(paramName);
            throw new ArgumentZeroException(ArgumentZeroString, paramName);
        }

        /// <summary>
        /// Throws an exception for a zero or less parameter.
        /// </summary>
        /// <param name="paramName">The name of the parameter.</param>
        /// <exception cref="ArgumentZeroException">The argument was zero or less.</exception>
        private static void ThrowZeroOrLessException(string? paramName)
        {
            ArgumentNullException.ThrowIfNull(paramName);
            throw new ArgumentZeroException(ArgumentZeroOrLessString, paramName);
        }

        #endregion

    }
}
