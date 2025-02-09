namespace Wolflight.Utilities.Exceptions.UnitTests
{
    public class ArgumentZeroExceptionTests
    {
        public class ThrowIfZeroMethod
        {
            [Fact]
            public void ThrowsWhenZeroInt()
            {
                ArgumentZeroException ex;
                Action<int> target = (x => { ArgumentZeroException.ThrowIfZero(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0));

                Assert.Equal("The provided argument was zero. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(int.MaxValue);
                target(1);
                target(-1);
                target(int.MinValue);
            }

            [Fact]
            public void ThrowsWhenZeroLong()
            {
                ArgumentZeroException ex;
                Action<long> target = (x => { ArgumentZeroException.ThrowIfZero(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0L));

                Assert.Equal("The provided argument was zero. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(long.MaxValue);
                target(1L);
                target(-1L);
                target(long.MinValue);
            }

            [Fact]
            public void ThrowsWhenZero()
            {
                ArgumentZeroException ex;
                Action<decimal> target = (x => { ArgumentZeroException.ThrowIfZero(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0M));

                Assert.Equal("The provided argument was zero. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(decimal.MaxValue);
                target(1M);
                target(-1M);
                target(decimal.MinValue);
            }
        }

        public class ThrowIfZeroOrLessMethod
        {
            [Fact]
            public void ThrowsWhenZeroInt()
            {
                ArgumentZeroException ex;
                Action<int> target = (x => { ArgumentZeroException.ThrowIfZeroOrLess(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(int.MaxValue);
                target(1);

                ex = Assert.Throws<ArgumentZeroException>(() => target(-1));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);
            }

            [Fact]
            public void ThrowsWhenZeroLong()
            {
                ArgumentZeroException ex;
                Action<long> target = (x => { ArgumentZeroException.ThrowIfZeroOrLess(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0L));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(long.MaxValue);
                target(1L);

                ex = Assert.Throws<ArgumentZeroException>(() => target(-1L));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);
            }

            [Fact]
            public void ThrowsWhenZero()
            {
                ArgumentZeroException ex;
                Action<decimal> target = (x => { ArgumentZeroException.ThrowIfZeroOrLess(x); });

                ex = Assert.Throws<ArgumentZeroException>(() => target(0M));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);

                target(decimal.MaxValue);
                target(1M);

                ex = Assert.Throws<ArgumentZeroException>(() => target(-1M));

                Assert.Equal("The provided argument was zero or less. (Parameter 'x')", ex.Message);
                Assert.Equal("x", ex.ParamName);
            }
        }


    }
}
