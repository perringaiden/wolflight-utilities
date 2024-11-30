
namespace Wolflight.Utilities.Collections.Dictionary
{
    public class ExtensionsTests
    {
        public class AddSetValueMethod
        {

            [Fact]
            public void AddsValueToEmptyDictionary()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>();
                KeyValuePair<string, ISet<int>> pair;
                int item;

                target.AddSetValue("Elephant", 1);

                pair = Assert.Single(target);

                Assert.Equal("Elephant", pair.Key);

                item = Assert.Single(pair.Value);

                Assert.Equal(1, item);

            }

            [Fact]
            public void AddsValueToNewKey()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>()
                {
                    {"Giraffe", new HashSet<int>{4,5} }
                };

                target.AddSetValue("Elephant", 1);

                Assert.Collection(
                    target.OrderBy(value => value.Key),
                    pair =>
                    {
                        int value;

                        Assert.Equal("Elephant", pair.Key);

                        value = Assert.Single(pair.Value);

                        Assert.Equal(1, value);
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);

                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
            }

            [Fact]
            public void AddsValueToExistingKey()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>()
                {
                    {"Giraffe", new HashSet<int>{4,5} },
                    {"Elephant", new HashSet<int> {2} }
                };

                target.AddSetValue("Elephant", 1);

                Assert.Collection(
                    target.OrderBy(value => value.Key),
                    pair =>
                    {
                        Assert.Equal("Elephant", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
            }

            [Fact]
            public void ThrowsExceptionWhenTheDictionaryIsNull()
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValue("Giraffe", 1));
#pragma warning restore CS8604 // Possible null reference argument.
            }

            [Fact]
            public void ThrowsExceptionWhenTheKeyIsNull()
            {
                Dictionary<string, ISet<int>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValue(null, 1));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }

            [Fact]
            public void ThrowsExceptionWhenTheValueIsNull()
            {
                Dictionary<string, ISet<string>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValue("Giraffe", null));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }
        }

        public class AddSetValuesMethod
        {
            [Fact]
            public void AddsValuesToEmptyDictionary()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>();

                target.AddSetValues("Elephant", [1, 2]);

                KeyValuePair<string, ISet<int>> pair = Assert.Single(target);

                Assert.Equal("Elephant", pair.Key);
                Assert.Collection(
                    pair.Value.Order(),
                    value => Assert.Equal(1, value),
                    value => Assert.Equal(2, value));
            }

            [Fact]
            public void AddsValuesToNewKey()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>()
                {
                    {"Giraffe", new HashSet<int>{4,5} }
                };

                target.AddSetValues("Elephant", [1, 2]);

                Assert.Collection(
                    target.OrderBy(value => value.Key),
                    pair =>
                    {
                        Assert.Equal("Elephant", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
            }

            [Fact]
            public void AddsValuesToExistingKey()
            {
                IDictionary<string, ISet<int>> target = new Dictionary<string, ISet<int>>()
                {
                    {"Giraffe", new HashSet<int>{4,5} },
                    {"Elephant", new HashSet<int> {3} }
                };

                target.AddSetValues("Elephant", [1, 2]);

                Assert.Collection(
                    target.OrderBy(value => value.Key),
                    pair =>
                    {
                        Assert.Equal("Elephant", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); },
                               value => { Assert.Equal(3, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.Order(),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
            }

            [Fact]
            public void ThrowsExceptionWhenTheDictionaryIsNull()
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValues("Giraffe", [1, 2]));
#pragma warning restore CS8604 // Possible null reference argument.
            }

            [Fact]
            public void ThrowsExceptionWhenTheKeyIsNull()
            {
                Dictionary<string, ISet<int>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValues(null, [1, 2]));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }

            [Fact]
            public void ThrowsExceptionWhenTheValuesIsNull()
            {
                Dictionary<string, ISet<string>> target = new();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                Assert.Throws<ArgumentNullException>(() => target.AddSetValues("Giraffe", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            }
        }
        public class RemoveSetValueMethod
        {

            [Fact]
            public void RemoveSetValueFromMultiItemSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    { "Giraffe", new HashSet<int>{1,2,3} }
                };

                Assert.True(target.RemoveSetValue("Giraffe", 2));

                Assert.Collection(
                    target["Giraffe"].Order(),
                    item => Assert.Equal(1, item),
                    item => Assert.Equal(3, item)
                );
            }

            [Fact]
            public void RemoveSetValueFromSingleItemSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    { "Giraffe", new HashSet<int>{2} }
                };

                Assert.True(target.RemoveSetValue("Giraffe", 2));

                Assert.Empty(target);
            }

            [Fact]
            public void RemoveSetValueFromEmptySet()
            {

                Dictionary<string, ISet<int>> target = new();

                Assert.False(target.RemoveSetValue("Giraffe", 2));

                Assert.Empty(target);
            }

            [Fact]
            public void RemoveSetValueFromMissingSet()
            {
                ArgumentNullException ex;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                ex = Assert.Throws<ArgumentNullException>(() => target.RemoveSetValue("Giraffe", 2));
#pragma warning restore CS8604 // Possible null reference argument.

                Assert.Equal("dictionary", ex.ParamName);
            }

            [Fact]
            public void ThrowsExceptionWhenTheDictionaryIsNull()
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Throws<ArgumentNullException>(() => target.RemoveSetValue("Giraffe", 1));
#pragma warning restore CS8604 // Possible null reference argument.
            }

            [Fact]
            public void ThrowsExceptionWhenTheKeyIsNull()
            {
                Dictionary<string, ISet<int>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.RemoveSetValue(null, 1));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }

            [Fact]
            public void ThrowsExceptionWhenTheValueIsNull()
            {
                Dictionary<string, ISet<string>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.RemoveSetValue("Giraffe", null));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }

        }

        public class GetValuesMethod
        {
            [Fact]
            public void RetrievesValuesFromPopulatedSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    {"Giraffe", new HashSet<int>{1,2} }
                };

                ISet<int>? values = target.GetValues("Giraffe");

                Assert.NotNull(values);
                Assert.Collection(
                    values.Order(),
                    x => Assert.Equal(1, x),
                    x => Assert.Equal(2, x)
                );
            }


            [Fact]
            public void RetrievesValuesFromEmptyExistingSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    {"Giraffe", new HashSet<int>() }
                };

                ISet<int>? values = target.GetValues("Giraffe");

                Assert.NotNull(values);
                Assert.Empty(values);
            }


            [Fact]
            public void RetrievesValuesFromNonExistentKey()
            {
                Dictionary<string, ISet<int>> target = new();

                ISet<int>? values = target.GetValues("Giraffe");

                Assert.NotNull(values);
                Assert.Empty(values);
                Assert.NotNull(target["Giraffe"]);
            }


            [Fact]
            public void ThrowsExceptionWhenTheDictionaryIsNull()
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Throws<ArgumentNullException>(() => target.GetValues("Giraffe"));
#pragma warning restore CS8604 // Possible null reference argument.
            }

            [Fact]
            public void ThrowsExceptionWhenTheKeyIsNull()
            {
                Dictionary<string, ISet<int>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.GetValues(null));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }


        }

        public class HasValuesMethod




        {

            [Fact]
            public void ReturnsTrueWhenValueIsFoundInExistingSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    {"Giraffe", new HashSet<int>{1,2} }
                };

                Assert.True(target.HasValue("Giraffe", 1));
            }


            [Fact]
            public void ReturnsFalseWhenValueIsNotFoundInExistingSet()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    {"Giraffe", new HashSet<int>{2} }
                };

                Assert.False(target.HasValue("Giraffe", 1));
            }


            [Fact]
            public void ReturnsFalseWhenSetDoesNotExist()
            {
                Dictionary<string, ISet<int>> target = new()
                {
                    {"Giraffe", new HashSet<int>{1,2} }
                };

                Assert.False(target.HasValue("Elephant", 1));
            }


            [Fact]
            public void ReturnsFalseWhenTheValueIsNull()
            {
                Dictionary<string, ISet<string>> target = new()
                {
                    {"Giraffe", new HashSet<string>{"Neck","Legs"} }
                };

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.False(target.HasValue("Giraffe", null));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }


            [Fact]
            public void ThrowsExceptionWhenTheDictionaryIsNull()
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Dictionary<string, ISet<int>> target = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
                Assert.Throws<ArgumentNullException>(() => target.HasValue("Giraffe", 1));
#pragma warning restore CS8604 // Possible null reference argument.
            }

            [Fact]
            public void ThrowsExceptionWhenTheKeyIsNull()
            {
                Dictionary<string, ISet<int>> target = new();

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
                Assert.Throws<ArgumentNullException>(() => target.HasValue(null, 1));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
            }


        }

    }

}

