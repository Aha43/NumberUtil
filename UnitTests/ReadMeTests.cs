using System;
using System.Collections.Generic;
using System.Linq;
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
            var largest = primeNumbers.Primes.Last(); // using LINQ to get the largest prime less or equal to N.
            Assert.Equal(211, largest);
        }

    }

}
