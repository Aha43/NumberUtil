using Xunit;

namespace NumberUtil
{
    public class NumbersXTests
    {
        // even

        // int
        [Fact]
        public void Is0Even()
        {
            Assert.True(0.IsEven());
            Assert.False(0.IsOdd());
        }

        [Fact]
        public void Is2Even()
        {
            Assert.True(2.IsEven());
            Assert.False(2.IsOdd());
        }

        [Fact]
        public void IsEven()
        {
            for (var n = -10; n < 101; n += 2)
            {
                Assert.True(n.IsEven());
                Assert.False(n.IsOdd());
            }
        }

        [Fact]
        public void IsOdd()
        {
            for (var n = -11; n < 100; n += 2)
            {
                Assert.False(n.IsEven());
                Assert.True(n.IsOdd());
            }
        }

        // long
        [Fact]
        public void Is0LEven()
        {
            Assert.True(0L.IsEven());
            Assert.False(0L.IsOdd());
        }

        [Fact]
        public void Is2LEven()
        {
            Assert.True(2L.IsEven());
            Assert.False(2L.IsOdd());
        }

        [Fact]
        public void IsLEven()
        {
            for (var n = -10L; n < 101L; n += 2L)
            {
                Assert.True(n.IsEven());
                Assert.False(n.IsOdd());
            }
        }

        [Fact]
        public void IsLOdd()
        {
            for (var n = -11L; n < 100L; n += 2L)
            {
                Assert.False(n.IsEven());
                Assert.True(n.IsOdd());
            }
        }

    }

}
