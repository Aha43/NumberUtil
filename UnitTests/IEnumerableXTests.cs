using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NumberUtil
{
    public class IEnumerableXTests
    {
        [Theory]
        [InlineData(0, new int[] { 0 })]
        [InlineData(0, new int[] { 1, 0 })]
        [InlineData(0, new int[] { 0, 0 })]
        [InlineData(0, new int[] { 0, 1 })]
        [InlineData(0, new int[] { 9, 8, 7, 0, 10, 0, 4 })]

        [InlineData(120, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(120, new int[] { 2, 3, 4, 5 })]
        [InlineData(-120, new int[] { 2, 3, -4, 5 })]
        public void ProductShouldBeInt(int expected, int[] f)
        {
            var p = f.Product();
            Assert.Equal(expected, p);
        }

        [Theory]
        [InlineData(0, new long[] { 0 })]
        [InlineData(0, new long[] { 1, 0 })]
        [InlineData(0, new long[] { 0, 0 })]
        [InlineData(0, new long[] { 0, 1 })]
        [InlineData(0, new long[] { 9, 8, 7, 0, 10, 0, 4 })]

        [InlineData(120, new long[] { 1, 2, 3, 4, 5 })]
        [InlineData(120, new long[] { 2, 3, 4, 5 })]
        [InlineData(-120, new long[] { 2, 3, -4, 5 })]
        public void ProductShouldBeLong(long expected, long[] f)
        {
            var p = f.Product();
            Assert.Equal(expected, p);
        }



    }

}
