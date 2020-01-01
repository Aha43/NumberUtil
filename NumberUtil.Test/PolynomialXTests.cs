using Xunit;

namespace NumberUtil.Test
{
    public class PolynomialXTests
    {
        // int

        [Fact]
        public void PolynomialTestingNullArray_int()
        {
            int[] p = null;

            Assert.Equal(0, p.Polynomial(0));
            Assert.Equal(0, p.Polynomial(100));
            Assert.Equal(0, p.Polynomial(-50));
        }

        [Fact]
        public void PolynomialTestingEmptyArray_int()
        {
            var p = new int[] { };

            Assert.Equal(0, p.Polynomial(0));
            Assert.Equal(0, p.Polynomial(100));
            Assert.Equal(0, p.Polynomial(-50));
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(-1, 5)]
        [InlineData(1, 5)]
        public void PolynomialTestingOneTerm_int(int x, int c)
        {
            var p = new int[] { c };

            Assert.Equal(c, p.Polynomial(x));
        }

        [Theory]

        [InlineData(1, 0, new int[] { 1, 1 })]
        [InlineData(2, 1, new int[] { 1, 1 })]
        [InlineData(5, 4, new int[] { 1, 1 })]

        [InlineData(3, 1, new int[] { 5, 2, -4, 0})]
        [InlineData(655, 5, new int[] { 5, 2, -4, 0 })]

        [InlineData(0, 1, new int[] { 5, 2, -4, -3 })]
        [InlineData(660, 5, new int[] { 5, 2, -4, 5 })]
        public void PolynomialTest_int(int expected, int x, int[] coefficients)
        {
            Assert.Equal(expected, coefficients.Polynomial(x));
        }

        [Fact]
        public void PolynomialTest_EulerProjectProblem27Example1_int()
        {
            var coefficients = new int[] { 1, 1, 41 };
            for (int i = 0; i < 40; i++)
            {
                Assert.True(coefficients.Polynomial(i).IsPrime());
            }

            Assert.False(coefficients.Polynomial(40).IsPrime());
        }

        [Fact]
        public void PolynomialTest_EulerProjectProblem27Example2_int()
        {
            var coefficients = new int[] { 1, -79, 1601 };
            for (int i = 0; i < 80; i++)
            {
                Assert.True(coefficients.Polynomial(i).IsPrime());
            }

            Assert.False(coefficients.Polynomial(80).IsPrime());
        }

        // long

        [Fact]
        public void PolynomialTestingNullArray_long()
        {
           long[] p = null;

            Assert.Equal(0L, p.Polynomial(0L));
            Assert.Equal(0L, p.Polynomial(100L));
            Assert.Equal(0L, p.Polynomial(-50L));
        }

        [Fact]
        public void PolynomialTestingEmptyArray_long()
        {
            var p = new long[] { };

            Assert.Equal(0L, p.Polynomial(0L));
            Assert.Equal(0L, p.Polynomial(100L));
            Assert.Equal(0L, p.Polynomial(-50L));
        }

        [Theory]
        [InlineData(0L, 5L)]
        [InlineData(-1L, 5L)]
        [InlineData(1L, 5L)]
        public void PolynomialTestingOneTerm_long(long x, long c)
        {
            var p = new long[] { c };

            Assert.Equal(c, p.Polynomial(x));
        }

        [Theory]

        [InlineData(1, 0, new long[] { 1L, 1L })]
        [InlineData(2, 1, new long[] { 1L, 1L })]
        [InlineData(5, 4, new long[] { 1L, 1L })]

        [InlineData(3, 1, new long[] { 5L, 2L, -4L, 0L })]
        [InlineData(655, 5, new long[] { 5L, 2L, -4L, 0L })]

        [InlineData(0, 1, new long[] { 5L, 2L, -4L, -3L })]
        [InlineData(660, 5, new long[] { 5L, 2L, -4L, 5L })]
        public void PolynomialTest_long(long expected, long x, long[] coefficients)
        {
            Assert.Equal(expected, coefficients.Polynomial(x));
        }

        [Fact]
        public void PolynomialTest_EulerProjectProblem27Example1_long()
        {
            var coefficients = new long[] { 1L, 1L, 41L };
            for (long i = 0; i < 40L; i++)
            {
                Assert.True(coefficients.Polynomial(i).IsPrime());
            }

            Assert.False(coefficients.Polynomial(40L).IsPrime());
        }

        [Fact]
        public void PolynomialTest_EulerProjectProblem27Example2_long()
        {
            var coefficients = new long[] { 1L, -79L, 1601L };
            for (long i = 0; i < 80L; i++)
            {
                Assert.True(coefficients.Polynomial(i).IsPrime());
            }

            Assert.False(coefficients.Polynomial(80L).IsPrime());
        }

    }

}
