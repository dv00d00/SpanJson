using System;

namespace SpanJson.Benchmarks.Fixture
{
    public class IntValueFixture : IValueFixture
    {
        private readonly Random _prng = new Random();
        public Type Type { get; } = typeof(int);

        public object Generate()
        {
            return _prng.Next(int.MinValue, int.MaxValue);
        }
    }
}