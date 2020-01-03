using Xunit;

namespace NumberUtil
{
    public class IsPrimeNumberTests
    {
        [Fact]
        public void IsPrimeTest()
        {
            var primes = new PrimeNumbers(10000);
            for (long i = 0; i <= primes.N; i++)
            {
                var expected = primes.IsPrime(i);
                Assert.Equal(expected, i.IsPrime());
            }
        }

    }

}
