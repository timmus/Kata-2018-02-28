using Kata1;
using System;
using Xunit;

namespace Kata1Tests
{
    public class UnitTest1
    {
        Class1 sut;

        public UnitTest1()
        {
            sut = new Class1();
        }

        [Fact]
        public void NullArrayReturnsNegOne()
        {
            Assert.Equal(-1, sut.chop(3, null));
        }

        [Fact]
        public void EmptyArrayReturnsNegOne()
        {
            Assert.Equal(-1, sut.chop(3, new int[] {}));
        }

        [Fact]
        public void InvalidMatchInSingleItemArrayReturnsNegOne()
        {
            Assert.Equal(-1, sut.chop(3, new int[] { 1 }));
        }

        [Fact]
        public void ValidMatchInSingleItemArrayReturnsZero()
        {
            Assert.Equal(0, sut.chop(1, new int[] { 1 }));
        }

        [Theory]
        [InlineData(0, 1, new int[] { 1, 3, 5 })]
        [InlineData(-1, 1, new int[] { 2, 3, 5 })]
        [InlineData(1, 3, new int[] { 1, 3, 5 })]
        [InlineData(2, 5, new int[] { 1, 3, 5 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5 })]
        public void valiateThreeItemHaystacks(
            int expected, int needle, int[] haystack)
        {
            Assert.Equal(expected, sut.chop(needle, haystack));
        }

        [Theory]
        [InlineData(0, 1, new int[] { 1, 3, 5, 7 })]
        [InlineData(1, 3, new int[] { 1, 3, 5, 7 })]
        [InlineData(2, 5, new int[] { 1, 3, 5, 7 })]
        [InlineData(3, 7, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 8, new int[] { 1, 3, 5, 7 })]
        public void valiateFourItemHaystacks(
    int expected, int needle, int[] haystack)
        {
            Assert.Equal(expected, sut.chop(needle, haystack));
        }
    }
}
