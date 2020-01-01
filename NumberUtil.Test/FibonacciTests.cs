using System.Linq;
using Xunit;

namespace NumberUtil.Test
{
    public class FibonacciTests
    {
        [Fact]
        public void Test10First()
        {
            var sequence = Sequences.Fibonacci.Take(10).ToArray();
            Assert.Equal(0,  sequence[0]);
            Assert.Equal(1,  sequence[1]);
            Assert.Equal(1,  sequence[2]);
            Assert.Equal(2,  sequence[3]);
            Assert.Equal(3,  sequence[4]);
            Assert.Equal(5,  sequence[5]);
            Assert.Equal(8,  sequence[6]);
            Assert.Equal(13, sequence[7]);
            Assert.Equal(21, sequence[8]);
            Assert.Equal(34, sequence[9]);
        }

    }

}
