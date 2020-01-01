using Xunit;

namespace NumberUtil.Test
{
    public class IsPrimeNumberTests
    {
        [Fact]
        public void IsPrimeTest()
        {
            var N = 10000L;
            var primes = N.PrimeNumbers();
            for (long i = 0; i <= N; i++)
            {
                var expected = primes.IsPrime(i);
                Assert.Equal(expected, i.IsPrime());
            }
        }

    }

}
