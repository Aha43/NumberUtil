using System.Numerics;
using Xunit;

namespace NumberUtil
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0042:Deconstruct variable declaration")]
    public class FactorialsXTests
    {
        [Fact]
        public void Fact0()
        {
            var f = 0.Factorial();

            Assert.Equal(1, f.Value);
            Assert.Equal(1, f.AsInt);
            Assert.Equal(1, f.AsLong);
        }

        [Fact]
        public void Fact1()
        {
            var f = 1.Factorial();

            Assert.Equal(1, f.Value);
            Assert.Equal(1, f.AsInt);
            Assert.Equal(1, f.AsLong);
        }

        [Fact]
        public void Fact2()
        {
            var f = 2.Factorial();

            Assert.Equal(2, f.Value);
            Assert.Equal(2, f.AsInt);
            Assert.Equal(2, f.AsLong);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        public void FactN(int n)
        {
            var f = n.Factorial();

            var expected = ComputeFactorial(n);

            Assert.Equal(expected, f.Value);
            Assert.Equal(expected, f.AsInt);
            Assert.Equal(expected, f.AsLong);
        }

        private int ComputeFactorial(int n)
        {
            var retVal = n;
            while (--n > 1) retVal *= n;
            return retVal;
        }

        // long

        [Fact]
        public void Fact0L()
        {
            var f = 0L.Factorial();

            Assert.Equal(1, f.Value);
            Assert.Equal(1, f.AsInt);
            Assert.Equal(1, f.AsLong);
        }

        [Fact]
        public void Fact1L()
        {
            var f = 1L.Factorial();

            Assert.Equal(1, f.Value);
            Assert.Equal(1, f.AsInt);
            Assert.Equal(1, f.AsLong);
        }

        [Fact]
        public void Fact2L()
        {
            var f = 2L.Factorial();

            Assert.Equal(2, f.Value);
            Assert.Equal(2, f.AsInt);
            Assert.Equal(2, f.AsLong);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        [InlineData(20)]
        public void FactNL(long n)
        {
            var f = n.Factorial();

            var expected = ComputeFactorial(n);

            var expectedAsInt = (n < 13) ? expected : 0;

            Assert.Equal(expected, f.Value);
            Assert.Equal(expectedAsInt, f.AsInt);
            Assert.Equal(expected, f.AsLong);
        }

        private long ComputeFactorial(long n)
        {
            var retVal = n;
            while (--n > 1) retVal *= n;
            return retVal;
        }

        [Theory]
        [InlineData(21)]
        [InlineData(50)]
        public void FactBig(int n)
        {
            var f = n.Factorial();

            var expected = ComputeBigFactorial(n);

            Assert.Equal(expected, f.Value);
            Assert.Equal(0, f.AsInt);
            Assert.Equal(0, f.AsLong);
        }

        [Theory]
        [InlineData(21)]
        [InlineData(50)]
        public void FactBigL(long n)
        {
            var f = n.Factorial();

            var expected = ComputeBigFactorial(n);

            Assert.Equal(expected, f.Value);
            Assert.Equal(0, f.AsInt);
            Assert.Equal(0, f.AsLong);
        }

        private BigInteger ComputeBigFactorial(long n)
        {
            var retVal = new BigInteger(n);
            while (--n > 1) retVal = BigInteger.Multiply(retVal, n);
            return retVal;
        }

    }

}
