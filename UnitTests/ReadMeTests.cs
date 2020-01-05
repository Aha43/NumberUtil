using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Xunit;

namespace NumberUtil
{
    public class ReadMeTests
    {
        [Fact]
        public void T1()
        {
            Assert.True(101.IsPrime()); // return true
            Assert.False(99.IsPrime()); // return false
        }

        [Fact]
        public void T2()
        {
            var N = 211;
            var primeNumbers = new PrimeNumbers(N); // the sieve
            var numberOfPrimes = primeNumbers.Count; // will be 47 if N = 211
            Assert.Equal(47, numberOfPrimes);
        }

        [Fact]
        public void T3()
        {
            var N = 211;
            var primeNumbers = new PrimeNumbers(N); // the sieve
            Assert.True(primeNumbers.IsPrime(101)); // true
            Assert.False(primeNumbers.IsPrime(210)); // false
            Assert.True(primeNumbers.IsPrime(211)); // true
        }

        [Fact]
        public void T4()
        {
            var N = 211;
            var primeNumbers = new PrimeNumbers(N); // the sieve
            var largest = primeNumbers.Last(); // using LINQ to get the largest prime less or equal to N.
            Assert.Equal(211, largest);
        }

        [Fact]
        public void T5()
        {
            Assert.Equal(5, 12345.NumberOfDigits()); // Returns 5
            Assert.Equal(5, (-12345).NumberOfDigits()); // Also returns 5: sign not counted
            Assert.Equal(22, BigInteger.Multiply(long.MaxValue, 1000).NumberOfDigits()); // Returns 22
            Assert.Equal(22, BigInteger.Multiply(long.MaxValue, -1000).NumberOfDigits());
        }

        [Fact]
        public void T6()
        {
            var factors = 30.PrimeFactors().ToArray(); // Array will contain 2, 3 and 5.
            Assert.Equal(3, factors.Length);
            Assert.Contains(2, factors);
            Assert.Contains(3, factors);
            Assert.Contains(5, factors);
        }

        [Fact]
        public void T7()
        {
            var dig = 12345.Digits(); // Gets array with digits 1, 2, 3, 4 and 5 (dig[0] = 1 and dig[4] = 5)

            Assert.Equal(5, dig.Length);
            Assert.Equal(1, dig[0]);
            Assert.Equal(2, dig[1]);
            Assert.Equal(3, dig[2]);
            Assert.Equal(4, dig[3]);
            Assert.Equal(5, dig[4]);
        }

        [Fact]
        public void T8()
        {
            var digits = 54321.Digits();
            Assert.Equal(54321, digits.Number()); // value = 54321.
        }

        [Fact]
        public void T9()
        {
            Assert.True(16.IsEven()); // returns true
            Assert.False(16.IsOdd()); // returns false
            Assert.False(17.IsEven()); // returns false
            Assert.True((-17).IsOdd()); // return true

        }

    }

}
