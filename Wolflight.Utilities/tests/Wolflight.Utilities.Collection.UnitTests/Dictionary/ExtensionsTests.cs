
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
                            pair.Value.OrderBy(value => value),
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
                            pair.Value.OrderBy(value => value),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.OrderBy(value => value),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
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
                    pair.Value.OrderBy(value => value),
                    value => Assert.Equal(1, value),
                    value => Assert.Equal(2, value));
            }

            [Fact]
            public void AddsValueToNewKey()
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
                            pair.Value.OrderBy(value => value),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.OrderBy(value => value),
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
                    {"Elephant", new HashSet<int> {3} }
                };

                target.AddSetValues("Elephant", [1, 2]);

                Assert.Collection(
                    target.OrderBy(value => value.Key),
                    pair =>
                    {
                        Assert.Equal("Elephant", pair.Key);
                        Assert.Collection(
                            pair.Value.OrderBy(value => value),
                               value => { Assert.Equal(1, value); },
                               value => { Assert.Equal(2, value); },
                               value => { Assert.Equal(3, value); }
                        );
                    },
                    pair =>
                    {
                        Assert.Equal("Giraffe", pair.Key);
                        Assert.Collection(
                            pair.Value.OrderBy(value => value),
                               value => { Assert.Equal(4, value); },
                               value => { Assert.Equal(5, value); }
                        );
                    }
                );
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
                    target["Giraffe"].OrderBy(item => item),
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


        }

        public class GetValuesMethod
        {
            // TODO: Implement.

        }

        public class HasValuesMethod
        {
            // TODO: Implement.

        }

    }
}
