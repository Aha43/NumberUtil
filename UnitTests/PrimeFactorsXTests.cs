using System.Linq;
using Xunit;

namespace NumberUtil
{
    public class PrimeFactorsXTests
    {
        [Fact]
        public void PrimeFactorsX_int_PrimeFactors()
        {
            for (int n = -10; n < 1000; n++)
            {
                // Compute data to test: Prime number factors of
                var factors = n.PrimeFactors().ToArray();

                // Test
                if (n < 2)
                {
                    // Test no factors for 0, 1 and negative numbers.
                    Assert.False(factors.Any());
                }
                else
                {
                    // Test that product of factor is n
                    Assert.Equal(n, factors.Product());

                    // Test that all factors are prime numbers
                    for (var i = 0; i < factors.Length; i++)
                    {
                        Assert.True(factors[i].IsPrime());
                    }
                }
            }
        }

    }

}
