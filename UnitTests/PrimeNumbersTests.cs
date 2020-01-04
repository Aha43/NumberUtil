using NumberUtil.TestData;
using System;
using System.Linq;
using Xunit;

namespace NumberUtil
{
    public class PrimeNumbersTests
    {
        [Fact]
        public void N0_GetAll()
        {
            var primes = new PrimeNumbers(0);

            Assert.Empty(primes);
        }

        [Fact]
        public void N1_GetAll()
        {
            var primes = new PrimeNumbers(1);

            Assert.Empty(primes);
        }

        [Fact]
        public void N2_GetAll()
        {
            var primes = new PrimeNumbers(2).ToArray();

            Assert.Single(primes);
            Assert.Equal(2, primes[0]);
        }

        [Fact]
        public void N3_GetAll()
        {
            var primes = new PrimeNumbers(3).ToArray();

            Assert.Equal(2, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
        }

        [Fact]
        public void N4_GetAll()
        {
            var primes = new PrimeNumbers(4).ToArray();

            Assert.Equal(2, primes.Length);
            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
        }

        [Fact]
        public void N5_GetAll()
        {
            var primes = new PrimeNumbers(5).ToArray();

            Assert.Equal(3, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
        }

        [Fact]
        public void N6_GetAll()
        {
            var primes = new PrimeNumbers(6).ToArray();

            Assert.Equal(3, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
        }

        [Fact]
        public void N7_GetAll()
        {
            var primes = new PrimeNumbers(7).ToArray();

            Assert.Equal(4, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
            Assert.Equal(7, primes[3]);
        }

        [Fact]
        public void N8_GetAll()
        {
            var primes = new PrimeNumbers(7).ToArray();

            Assert.Equal(4, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
            Assert.Equal(7, primes[3]);
        }

        [Fact]
        public void N0_TestIfPrime()
        {
            var primes = new PrimeNumbers(0);

            Assert.Equal(0, primes.N);
            Assert.Equal(0, primes.Count);
            Assert.False(primes.IsPrime(0));
        }

        [Fact]
        public void N1_TestIfPrime()
        {
            var primes = new PrimeNumbers(1);

            Assert.Equal(1, primes.N);
            Assert.Equal(0, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
        }

        [Fact]
        public void N2_TestIfPrime()
        {
            var primes = new PrimeNumbers(2);

            Assert.Equal(2, primes.N);
            Assert.Equal(1, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
        }

        [Fact]
        public void N3_TestIfPrime()
        {
            var primes = new PrimeNumbers(3);

            Assert.Equal(3, primes.N);
            Assert.Equal(2, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
            Assert.True(primes.IsPrime(3));
        }

        [Fact]
        public void N4_TestIfPrime()
        {
            var primes = new PrimeNumbers(4);

            Assert.Equal(4, primes.N);
            Assert.Equal(2, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
            Assert.True(primes.IsPrime(3));
            Assert.False(primes.IsPrime(4));
        }

        [Fact]
        public void N5_TestIfPrime()
        {
            var primes = new PrimeNumbers(5);

            Assert.Equal(5, primes.N);
            Assert.Equal(3, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
            Assert.True(primes.IsPrime(3));
            Assert.False(primes.IsPrime(4));
            Assert.True(primes.IsPrime(5));
        }

        [Fact]
        public void N6_TestIfPrime()
        {
            var primes = new PrimeNumbers(6);

            Assert.Equal(6, primes.N);
            Assert.Equal(3, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
            Assert.True(primes.IsPrime(3));
            Assert.False(primes.IsPrime(4));
            Assert.True(primes.IsPrime(5));
            Assert.False(primes.IsPrime(6));
        }

        [Fact]
        public void CountPrimesUpTo10K()
        {
            var primes = new PrimeNumbers(10000);

            Assert.Equal(10000, primes.N);
            Assert.Equal(1229, primes.Count);
        }

        [Theory]
        [ClassData(typeof(PrimeNumbersTestData))]
        public void N103_TestIfPrime(long N, long n, bool expected)
        {
            var primes = new PrimeNumbers(N);

            Assert.Equal(expected, primes.IsPrime(n));
        }

        [Fact]
        public void EnumerateOverFirstUnder20()
        {
            var i = 1;
            foreach (var p in new PrimeNumbers(20))
            {
                switch (i++)
                {
                    case 1: Assert.Equal(2, p); break;
                    case 2: Assert.Equal(3, p); break;
                    case 3: Assert.Equal(5, p); break;
                    case 4: Assert.Equal(7, p); break;
                    case 5: Assert.Equal(11, p); break;
                    case 6: Assert.Equal(13, p); break;
                    case 7: Assert.Equal(17, p); break;
                    case 8: Assert.Equal(19, p); break;
                    default: throw new Exception();
                }
            }
        }

    }

}
