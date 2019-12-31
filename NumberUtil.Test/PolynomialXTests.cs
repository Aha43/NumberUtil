using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NumberUtil;

namespace NumberUtil.Test
{
    public class PolynomialXTests
    {
        [Fact]
        public void PolynomialTestingNullArray()
        {
            int[] p = null;

            Assert.Equal(0, p.Polynomial(0));
            Assert.Equal(0, p.Polynomial(100));
            Assert.Equal(0, p.Polynomial(-50));
        }

        [Fact]
        public void PolynomialTestingEmptyArray()
        {
            var p = new int[] { };

            Assert.Equal(0, p.Polynomial(0));
            Assert.Equal(0, p.Polynomial(100));
            Assert.Equal(0, p.Polynomial(-50));
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(-1, 5)]
        [InlineData(1, 5)]
        public void PolynomialTestingOneTerm(int x, int c)
        {
            var p = new int[] { c };

            Assert.Equal(c, p.Polynomial(x));
        }

        [Theory]

        [InlineData(1, 0, new int[] { 1, 1 })]
        [InlineData(2, 1, new int[] { 1, 1 })]
        [InlineData(5, 4, new int[] { 1, 1 })]

        [InlineData(3, 1, new int[] { 5, 2, -4, 0})]
        [InlineData(655, 5, new int[] { 5, 2, -4, 0 })]

        [InlineData(0, 1, new int[] { 5, 2, -4, -3 })]
        [InlineData(660, 5, new int[] { 5, 2, -4, 5 })]
        public void PolynomialTest(int expected, int x, int[] coefficients)
        {
            Assert.Equal(expected, coefficients.Polynomial(x));
        }

    }

}
