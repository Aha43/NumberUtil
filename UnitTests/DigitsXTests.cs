﻿using System.Numerics;
using Xunit;

namespace NumberUtil
{
    public class DigitsXTests
    {
        //
        // int
        //

        [Fact]
        public void DigitsOf_0()
        {
            int[] digits = 0.Digits();

            Assert.Single(digits);
            Assert.Equal(0, digits[0]);
        }

        [Fact]
        public void DigitsOf_1()
        {
            int[] digits = 1.Digits();

            Assert.Single(digits);

            Assert.Equal(1, digits[0]);
        }

        [Fact]
        public void DigitsOf_12()
        {
            int[] digits = 12.Digits();

            Assert.Equal(2, digits.Length);

            Assert.Equal(1, digits[0]);
            Assert.Equal(2, digits[1]);
        }

        [Fact]
        public void DigitsOf_2147483647()
        {
            int n = int.MaxValue;

            Assert.Equal(2147483647, n);

            var digits = n.Digits();

            Assert.Equal(10, digits.Length);

            Assert.Equal(2, digits[0]);
            Assert.Equal(1, digits[1]);
            Assert.Equal(4, digits[2]);
            Assert.Equal(7, digits[3]);
            Assert.Equal(4, digits[4]);
            Assert.Equal(8, digits[5]);
            Assert.Equal(3, digits[6]);
            Assert.Equal(6, digits[7]);
            Assert.Equal(4, digits[8]);
            Assert.Equal(7, digits[9]);
        }

        [Fact]
        public void DigitsOf_2147483648()
        {
            var n = 2147483648L;

            var digits = n.Digits();

            Assert.Equal(10, digits.Length);

            Assert.Equal(2, digits[0]);
            Assert.Equal(1, digits[1]);
            Assert.Equal(4, digits[2]);
            Assert.Equal(7, digits[3]);
            Assert.Equal(4, digits[4]);
            Assert.Equal(8, digits[5]);
            Assert.Equal(3, digits[6]);
            Assert.Equal(6, digits[7]);
            Assert.Equal(4, digits[8]);
            Assert.Equal(8, digits[9]);
        }

        [Fact]
        public void DigitsOf_90612345123875509091827560007100099()
        {
            var nstring = "90612345123875509091827560007100099";
            var expected = new int[nstring.Length];
            for (var i = 0; i < expected.Length; i++) expected[i] = int.Parse(nstring[i].ToString());

            var n = BigInteger.Parse("90612345123875509091827560007100099");

            var digits = n.Digits();

            Assert.Equal(expected.Length, digits.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], digits[i]);
            }
        }

        [Theory]
        [InlineData(0, new int[] { 0 })]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 2 })]
        [InlineData(123, new int[] { 1, 2, 3})]

        public void ToNumberInt(int expected, int[] digits)
        {
            Assert.Equal(expected, digits.Number());
        }

        [Theory]
        [InlineData(0L, new long[] { 0L })]
        [InlineData(1L, new long[] { 1L })]
        [InlineData(2L, new long[] { 2L })]
        [InlineData(123L, new long[] { 1L, 2L, 3L })]

        public void ToNumberLong(long expected, long[] digits)
        {
            Assert.Equal(expected, digits.Number());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(123)]
        [InlineData(int.MaxValue)]
        public void TestingDigitsAndNumberInt(int number)
        {
            var digits = number.Digits();
            Assert.Equal(number, digits.Number());
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(1L)]
        [InlineData(2L)]
        [InlineData(123L)]
        [InlineData(int.MaxValue)]
        [InlineData(long.MaxValue)]
        public void TestingDigitsAndNumberLong(long number)
        {
            var digits = number.Digits();
            Assert.Equal(number, digits.Number());
        }

        [Theory]
        [InlineData(true, new int[] { })]
        [InlineData(true, new int[] { 0 })]
        [InlineData(true, new int[] { 5 })]
        [InlineData(false, new int[] { 1, 2 })]
        [InlineData(false, new int[] { 2, 1 })]
        [InlineData(true, new int[] { 1, 1 })]
        [InlineData(false, new int[] { 8, 1, 1, 9 })]
        [InlineData(true, new int[] { 8, 1, 1, 8 })]
        public void Palindrom(bool expected, int[] digits)
        {
            Assert.Equal(expected, digits.IsPalindrome());
        }

    }

}
