using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NumberUtil
{
    public class ClosedFormsTests
    {
        #region sums
        [Theory]
        [InlineData(5)]
        public void SumOfNumbers(int n) => SumTester(Sequences.Natural, n, ClosedForms.SumOfNumbers);

        [Theory]
        [InlineData(5)]
        public void SquareOfNumbers(int n) => SumTester(Sequences.Squares, n, ClosedForms.SumOfSquares);

        private static void SumTester(IEnumerable<long> sequence, int n, Func<long, long> closedForm)
        {
            var elements = sequence.Take(n).ToArray();
            var expected = 0L;
            for (var i = 0L; i < n; i++)
            {
                expected += elements[i];
                var computed = closedForm(i);
                Assert.Equal(expected, computed);
            }
        }
        #endregion

        #region nth
        [Theory]
        [InlineData(20)]
        public void Fibonacci(int n) => SequenceTester(Sequences.Fibonacci, n, ClosedForms.NthFibonacci);

        private static void SequenceTester(IEnumerable<long> sequence, int n, Func<long, long> closedForm, long x = 0)
        {
            var elements = sequence.Take(n).ToArray();
            for (long i = 0; i < n; i++, x++)
            {
                var expected = elements[i];
                Assert.Equal(expected, closedForm(x));
            }
        }
        #endregion

    }

}
