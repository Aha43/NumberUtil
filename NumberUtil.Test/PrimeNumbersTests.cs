using NumberUtil.Test.TestData;
using System.Linq;
using Xunit;

//
// TODO: More range tests.
//

namespace NumberUtil.Test
{
    public class PrimeNumbersTests
    {
        [Fact]
        public void N0_GetAll()
        {
            long N = 0;
            var primes = N.PrimeNumbers().Primes();

            Assert.Empty(primes);
        }

        [Fact]
        public void N1_GetAll()
        {
            var primes = 1L.PrimeNumbers().Primes();

            Assert.Empty(primes);
        }

        [Fact]
        public void N2_GetAll()
        {
            var primes = 2L.PrimeNumbers().Primes().ToArray();

            Assert.Single(primes);
            Assert.Equal(2, primes[0]);
        }

        [Fact]
        public void N3_GetAll()
        {
            var primes = 3L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(2, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
        }

        [Fact]
        public void N4_GetAll()
        {
            var primes = 4L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(2, primes.Length);
            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
        }

        [Fact]
        public void N5_GetAll()
        {
            var primes = 5L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(3, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
        }

        [Fact]
        public void N6_GetAll()
        {
            var primes = 6L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(3, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
        }

        [Fact]
        public void N7_GetAll()
        {
            var primes = 7L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(4, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
            Assert.Equal(7, primes[3]);
        }

        [Fact]
        public void N8_GetAll()
        {
            var primes = 8L.PrimeNumbers().Primes().ToArray();

            Assert.Equal(4, primes.Length);

            Assert.Equal(2, primes[0]);
            Assert.Equal(3, primes[1]);
            Assert.Equal(5, primes[2]);
            Assert.Equal(7, primes[3]);
        }

        [Fact]
        public void N0_TestIfPrime()
        {
            var primes = 0L.PrimeNumbers();

            Assert.Equal(0, primes.N);
            Assert.Equal(0, primes.Count);
            Assert.False(primes.IsPrime(0));
        }

        [Fact]
        public void N1_TestIfPrime()
        {
            var primes = 1L.PrimeNumbers();

            Assert.Equal(1, primes.N);
            Assert.Equal(0, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
        }

        [Fact]
        public void N2_TestIfPrime()
        {
            var primes = 2L.PrimeNumbers();

            Assert.Equal(2, primes.N);
            Assert.Equal(1, primes.Count);
            Assert.False(primes.IsPrime(0));
            Assert.False(primes.IsPrime(1));
            Assert.True(primes.IsPrime(2));
        }

        [Fact]
        public void N3_TestIfPrime()
        {
            var primes = 3L.PrimeNumbers();

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
            var primes = 4L.PrimeNumbers();

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
            var primes = 5L.PrimeNumbers();

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
            var primes = 6L.PrimeNumbers();

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
            var primes = 10000L.PrimeNumbers();

            Assert.Equal(10000, primes.N);
            Assert.Equal(1229, primes.Count);
        }

        [Theory]
        [ClassData(typeof(PrimeNumbersTestData))]
        public void N103_TestIfPrime(long N, long n, bool expected)
        {
            var primes = N.PrimeNumbers();

            Assert.Equal(expected, primes.IsPrime(n));
        }

    }

}
