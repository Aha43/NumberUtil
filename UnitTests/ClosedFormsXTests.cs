using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static NumberUtil.ClosedForms;

namespace NumberUtil
{
    public class ClosedFormsXTests
    {
        [Theory]
        [InlineData(5)]
        public void SumOfNumbers(int n) => SumTester(Sequences.Natural, n, ClosedForms.SumOfNumbers);

        [Theory]
        [InlineData(5)]
        public void SquareOfNumbers(int n) => SumTester(Sequences.Squares, n, ClosedForms.SumOfSquares);

        //[Theory]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        //[InlineData(5)]
        //public void Fibonacci(int n) => SumTester(Sequences.Fibonacci, n, ClosedFormsX.SumOfFibonaccis);

        [Fact]
        public void Fibonacci3()
        {
            var computed = SumOfFibonaccis(3);
            Assert.Equal(2, computed);
        }

        [Fact]
        public void Fibonacci4()
        {
            var computed = SumOfFibonaccis(4);
            Assert.Equal(4, computed);
        }

        [Fact]
        public void Fibonacci5()
        {
            var computed = SumOfFibonaccis(5);
            Assert.Equal(7, computed);
        }

        private static void SumTester(IEnumerable<long> sequences, int n, Func<long, long> closedForm)
        {
            var elements = sequences.Take(n).ToArray();
            var expected = 0L;
            for (var i = 0L; i < n; i++)
            {
                expected += elements[i];
                var computed = closedForm(i);
                Assert.Equal(expected, computed);
            }
        }

    }

}
