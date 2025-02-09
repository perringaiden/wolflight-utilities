using Wolflight.Utilities.Testing;

namespace Woflight.Utilities.Testing
{
    public class IntegralAssertionExtensions
    {

        public class AssertZeroMethod
        {
            [Fact()]
            public void ZeroPasses()
            {
                0.AssertZero();
                ((short)0).AssertZero();
                0L.AssertZero();
                ((byte)0).AssertZero();
                ((ushort)0).AssertZero();
                ((uint)0).AssertZero();
                ((ulong)0).AssertZero();

            }

            [Fact()]
            public void NonZeroFails()
            {
                Assert.Throws<Xunit.Sdk.EqualException>(() => 1.AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((short)1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => 1L.AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((byte)1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((ushort)1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((uint)1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((ulong)1).AssertZero());

                Assert.Throws<Xunit.Sdk.EqualException>(() => (-1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => ((short)-1).AssertZero());
                Assert.Throws<Xunit.Sdk.EqualException>(() => (-1L).AssertZero());
            }

        }

        public class AssertNonZeroMethod
        {

            [Fact()]
            public void ZeroFails()
            {
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => 0.AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => ((short)0).AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => 0L.AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => ((byte)0).AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => ((ushort)0).AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => ((uint)0).AssertNonZero());
                Assert.Throws<Xunit.Sdk.NotEqualException>(() => ((ulong)0).AssertNonZero());


            }

            [Fact]
            public void NonZeroPasses()
            {
                1.AssertNonZero();
                ((short)1).AssertNonZero();
                1L.AssertNonZero();
                ((byte)1).AssertNonZero();
                ((ushort)1).AssertNonZero();
                ((uint)1).AssertNonZero();
                ((ulong)1).AssertNonZero();

                (-1).AssertNonZero();
                ((short)-1).AssertNonZero();
                (-1L).AssertNonZero();
            }


        }

    }

}
