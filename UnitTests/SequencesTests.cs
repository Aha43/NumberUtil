using System.Linq;
using Xunit;

namespace NumberUtil
{
    public class SequencesTests
    {
        [Fact]
        public void Test10FirstNatural()
        {
            int expected = 0;
            foreach (var e in Sequences.Natural)
            {
                Assert.Equal(expected++, e);
                if (expected > 9) return;
            }
        }

        [Fact]
        public void Test10FirstSquare()
        {
            int n = 0;
            foreach (var e in Sequences.Squares)
            {
                var expected = n * n;
                n++;
                Assert.Equal(expected++, e);
                if (n > 9) return;
            }
        }

        [Fact]
        public void Test10FirstFibonacci()
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
