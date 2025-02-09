
using Xunit;

namespace Wolflight.Utilities.Testing
{
    public static class IntegralAssertionExtensions
    {
        #region int

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this int actual)
        {
            Assert.Equal(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this int actual)
        {
            Assert.NotEqual(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this int actual)
        {
            Assert.InRange(actual, 1, int.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is negative.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNegative(this int actual)
        {
            Assert.InRange(actual, int.MinValue, -1);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this int actual, int maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(maximum, int.MinValue);

            Assert.InRange(actual, int.MinValue, maximum - 1);
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this int actual, int maximum)
        {
            Assert.InRange(actual, int.MinValue, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this int actual, int minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(minimum, int.MaxValue);

            Assert.InRange(actual, minimum + 1, int.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this int actual, int minimum)
        {
            Assert.InRange(actual, minimum, int.MaxValue);
        }


        #endregion


        #region short

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this short actual)
        {
            Assert.Equal(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this short actual)
        {
            Assert.NotEqual(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this short actual)
        {
            Assert.InRange(actual, 1, short.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is negative.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNegative(this short actual)
        {
            Assert.InRange(actual, short.MinValue, -1);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this short actual, short maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(maximum, short.MinValue);

            Assert.InRange(actual, short.MinValue, maximum - 1);
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this short actual, short maximum)
        {
            Assert.InRange(actual, short.MinValue, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this short actual, short minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(minimum, short.MaxValue);

            Assert.InRange(actual, minimum + 1, short.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this short actual, short minimum)
        {
            Assert.InRange(actual, minimum, short.MaxValue);
        }


        #endregion


        #region long

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this long actual)
        {
            Assert.Equal(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this long actual)
        {
            Assert.NotEqual(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this long actual)
        {
            Assert.InRange(actual, 1, long.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is negative.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNegative(this long actual)
        {
            Assert.InRange(actual, long.MinValue, -1);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this long actual, long maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(maximum, long.MinValue);

            Assert.InRange(actual, long.MinValue, maximum - 1);
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this long actual, long maximum)
        {
            Assert.InRange(actual, long.MinValue, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this long actual, long minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual(minimum, long.MaxValue);

            Assert.InRange(actual, minimum + 1, long.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this long actual, long minimum)
        {
            Assert.InRange(actual, minimum, long.MaxValue);
        }


        #endregion


        #region byte

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this byte actual)
        {
            Assert.Equal<byte>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this byte actual)
        {
            Assert.NotEqual<byte>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this byte actual)
        {
            Assert.InRange<byte>(actual, 1, byte.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this byte actual, byte maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<byte>(maximum, 0);

            Assert.InRange<byte>(actual, 0, (byte)(maximum - 1));
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this byte actual, byte maximum)
        {
            Assert.InRange<byte>(actual, 0, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this byte actual, byte minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<byte>(minimum, byte.MaxValue);

            Assert.InRange<byte>(actual, (byte)(minimum + 1), byte.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this byte actual, byte minimum)
        {
            Assert.InRange<byte>(actual, minimum, byte.MaxValue);
        }


        #endregion


        #region uint

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this uint actual)
        {
            Assert.Equal<uint>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this uint actual)
        {
            Assert.NotEqual<uint>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this uint actual)
        {
            Assert.InRange<uint>(actual, 1, uint.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this uint actual, uint maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<uint>(maximum, 0);

            Assert.InRange<uint>(actual, 0, (uint)(maximum - 1));
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this uint actual, uint maximum)
        {
            Assert.InRange<uint>(actual, 0, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this uint actual, uint minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<uint>(minimum, uint.MaxValue);

            Assert.InRange<uint>(actual, (uint)(minimum + 1), uint.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this uint actual, uint minimum)
        {
            Assert.InRange<uint>(actual, minimum, uint.MaxValue);
        }


        #endregion


        #region ushort

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this ushort actual)
        {
            Assert.Equal<ushort>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this ushort actual)
        {
            Assert.NotEqual<ushort>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this ushort actual)
        {
            Assert.InRange<ushort>(actual, 1, ushort.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this ushort actual, ushort maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<ushort>(maximum, 0);

            Assert.InRange<ushort>(actual, 0, (ushort)(maximum - 1));
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this ushort actual, ushort maximum)
        {
            Assert.InRange<ushort>(actual, 0, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this ushort actual, ushort minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<ushort>(minimum, ushort.MaxValue);

            Assert.InRange<ushort>(actual, (ushort)(minimum + 1), ushort.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this ushort actual, ushort minimum)
        {
            Assert.InRange<ushort>(actual, minimum, ushort.MaxValue);
        }


        #endregion


        #region ulong

        /// <summary>
        /// Asserts that a value is zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertZero(this ulong actual)
        {
            Assert.Equal<ulong>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is not zero.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertNonZero(this ulong actual)
        {
            Assert.NotEqual<ulong>(0, actual);
        }


        /// <summary>
        /// Asserts that a value is positive.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        public static void AssertPositive(this ulong actual)
        {
            Assert.InRange<ulong>(actual, 1, ulong.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is less than a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than this value.</param>
        public static void AssertLessThan(this ulong actual, ulong maximum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<ulong>(maximum, 0);

            Assert.InRange<ulong>(actual, 0, (ulong)(maximum - 1));
        }


        /// <summary>
        /// Asserts that a value is less than or equal to a maximum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="maximum">The value must be less than or equal to this.</param>
        public static void AssertLessThanOrEqualTo(this ulong actual, ulong maximum)
        {
            Assert.InRange<ulong>(actual, 0, maximum);
        }


        /// <summary>
        /// Asserts that a value is greater than a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than this value.</param>
        public static void AssertGreaterThan(this ulong actual, ulong minimum)
        {
            ArgumentOutOfRangeException.ThrowIfEqual<ulong>(minimum, ulong.MaxValue);

            Assert.InRange<ulong>(actual, (ulong)(minimum + 1), ulong.MaxValue);
        }


        /// <summary>
        /// Asserts that a value is greater than or equal to a minimum.
        /// </summary>
        /// <param name="actual">The value to check.</param>
        /// <param name="minimum">The value must be greater than or equal to this value.</param>
        public static void AssertGreaterThanOrEqualTo(this ulong actual, ulong minimum)
        {
            Assert.InRange<ulong>(actual, minimum, ulong.MaxValue);
        }


        #endregion
    }

}

