using System.Collections.Generic;
using Xunit;

namespace AtCoder.ABC107.D.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [MemberData(nameof(MedianTestData))]
        public void GetMedian(IEnumerable<long> list, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetMedian(list));
        }

        public static TheoryData<IEnumerable<long>, int> MedianTestData => new TheoryData<IEnumerable<long>, int>
        {
            { new long[] { 10 }, 10 },
            { new long[] { 10, 30 }, 30 },
            { new long[] { 30, 20 }, 30 },
            { new long[] { 10, 30, 20 }, 20 },
            { new long[] { 5, 9, 5, 9, 8, 9, 3, 5, 4, 3 }, 5 },
        };

        [Theory]
        [MemberData(nameof(MedianOfMediansTestData))]
        public void GetMedianOfMesians(IEnumerable<long> list, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetMedianOfMedians(list));
        }

        public static TheoryData<IEnumerable<long>, int> MedianOfMediansTestData => new TheoryData<IEnumerable<long>, int>
        {
            { new long[] { 10, 30, 20 }, 30 },
            { new long[] { 10 }, 10 },
            { new long[] { 5, 9, 5, 9, 8, 9, 3, 5, 4, 3 }, 8 },
        };

        [Theory]
        [MemberData(nameof(SubListsTestData))]
        public void GetSubListsTest(IEnumerable<long> list, IEnumerable<IEnumerable<long>> expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.GetSubLists(list));
        }

        public static TheoryData<IEnumerable<long>, IEnumerable<IEnumerable<long>>> SubListsTestData => new TheoryData<IEnumerable<long>, IEnumerable<IEnumerable<long>>>
        {
            {
                new long[] { 10, 30, 20 },
                new []
                {
                    new long[]{ 10 },
                    new long[]{ 10, 30 },
                    new long[]{ 10, 30, 20 },
                    new long[]{ 30 },
                    new long[]{ 30, 20 },
                    new long[]{ 20 },
                }
            },
        };
    }
}
