namespace Wolflight.Utilities.Collections.IEnumerable
{
    public class ExtensionsTests
    {
        public class IsEmptyMethod
        {
            [Fact]
            public void EnumerableIsEmpty()
            {
                IEnumerable<int>? nullValue;
                IEnumerable<int>? emptyValue;
                IEnumerable<int>? singleValue;
                IEnumerable<int>? multiValue;

                nullValue = null;
                emptyValue = Array.Empty<int>();
                singleValue = [1];
                multiValue = [1, 2, 3];

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.True(nullValue.IsEmpty());
#pragma warning restore CS8604 // Possible null reference argument.
                Assert.True(emptyValue.IsEmpty());
                Assert.False(singleValue.IsEmpty());
                Assert.False(multiValue.IsEmpty());
            }

            [Fact]
            public void CollectionIsEmpty()
            {
                ICollection<int>? nullValue;
                ICollection<int>? emptyValue;
                ICollection<int>? singleValue;
                ICollection<int>? multiValue;

                nullValue = null;
                emptyValue = Array.Empty<int>();
                singleValue = [1];
                multiValue = [1, 2, 3];

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.True(nullValue.IsEmpty());
#pragma warning restore CS8604 // Possible null reference argument.
                Assert.True(emptyValue.IsEmpty());
                Assert.False(singleValue.IsEmpty());
                Assert.False(multiValue.IsEmpty());
            }
        }
        public class IsNotEmptyMethod
        {
            [Fact]
            public void EnumerableIsNotEmpty()
            {
                IEnumerable<int>? nullValue;
                IEnumerable<int>? emptyValue;
                IEnumerable<int>? singleValue;
                IEnumerable<int>? multiValue;

                nullValue = null;
                emptyValue = Array.Empty<int>();
                singleValue = [1];
                multiValue = [1, 2, 3];

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.False(nullValue.IsNotEmpty());
#pragma warning restore CS8604 // Possible null reference argument.
                Assert.False(emptyValue.IsNotEmpty());
                Assert.True(singleValue.IsNotEmpty());
                Assert.True(multiValue.IsNotEmpty());
            }

            [Fact]
            public void CollectionIsNotEmpty()
            {
                ICollection<int>? nullValue;
                ICollection<int>? emptyValue;
                ICollection<int>? singleValue;
                ICollection<int>? multiValue;

                nullValue = null;
                emptyValue = Array.Empty<int>();
                singleValue = [1];
                multiValue = [1, 2, 3];

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.False(nullValue.IsNotEmpty());
#pragma warning restore CS8604 // Possible null reference argument.
                Assert.False(emptyValue.IsNotEmpty());
                Assert.True(singleValue.IsNotEmpty());
                Assert.True(multiValue.IsNotEmpty());
            }
        }

        public class ToCsvMethod
        {
            [Fact]
            public void PrimitiveEnumerableReturnsCorrectValue()
            {
                IEnumerable<int>? nullValue;
                IEnumerable<int>? emptyValue;
                IEnumerable<int>? singleValue;
                IEnumerable<int>? multiValue;

                nullValue = null;
                emptyValue = Array.Empty<int>();
                singleValue = [1];
                multiValue = [1, 2, 3];

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Equal("", nullValue.ToCsv());
#pragma warning restore CS8604 // Possible null reference argument.
                Assert.Equal("", emptyValue.ToCsv());
                Assert.Equal("1", singleValue.ToCsv());
                Assert.Equal("1, 2, 3", multiValue.ToCsv());
            }

            [Fact]
            public void CustomEnumerableReturnsCorrectValue()
            {
                IEnumerable<StringDisplayer>? values;

                values = [new StringDisplayer(1), new StringDisplayer(2), new StringDisplayer(3)];

                Assert.Equal("1, 2, 3", values.ToCsv());
            }

            private class StringDisplayer
            {
                public StringDisplayer(int value)
                {
                    Value = value;
                }

                public int Value { get; }
                public override string ToString()
                {
                    return Value.ToString();
                }
            }
        }
    }
}
