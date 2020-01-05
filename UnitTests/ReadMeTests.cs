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
            var dig1 = 12345.Digits(); // Gets array with digits 1, 2, 3, 4 and 5 (dig1[0] = 1 and dig1[4] = 5)
            var dig2 = (-12345).Digits(); // Gets array with digits -1, -2, -3, -4 and -5 (dig2[0] = -1 and dig2[4] = -5)

            Assert.Equal(5, dig1.Length);
            Assert.Equal(1, dig1[0]);
            Assert.Equal(2, dig1[1]);
            Assert.Equal(3, dig1[2]);
            Assert.Equal(4, dig1[3]);
            Assert.Equal(5, dig1[4]);

            Assert.Equal(5, dig2.Length);
            Assert.Equal(-1, dig2[0]);
            Assert.Equal(-2, dig2[1]);
            Assert.Equal(-3, dig2[2]);
            Assert.Equal(-4, dig2[3]);
            Assert.Equal(-5, dig2[4]);
        }

    }

}
