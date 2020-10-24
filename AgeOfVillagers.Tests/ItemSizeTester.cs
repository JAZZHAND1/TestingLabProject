using Login;
using System;
using System.Drawing;
using Xunit;
namespace AgeOfVillagers.Tests
{
    public class ItemSizeTester
    {
        [Fact]
        public void ArabHouseSizeTest()
        {
            Assert.Equal(16, new ArabHouse().getHeight());
            Assert.Equal(16, new ArabHouse().getWidth());
        }

        [Fact]
        public void BDHouseSizeTest()
        {
            Assert.Equal(16, new BangladeshiHouse().getHeight());
            Assert.Equal(16, new BangladeshiHouse().getWidth());
        }

        [Fact]
        public void EgyptHouseSizeTest()
        {
            Assert.Equal(16, new EgyptianHouse().getHeight());
            Assert.Equal(16, new EgyptianHouse().getWidth());
        }

        [Fact]
        public void InuitHuntersHouseSizeTest()
        {
            Assert.Equal(16, new InuitHuntersHouse().getHeight());
            Assert.Equal(16, new InuitHuntersHouse().getWidth());
        }

        [Fact]
        public void BDWaterSourceSizeTest()
        {
            Assert.Equal(24, new BangladeshiWaterResource().getWidth());
            Assert.Equal(16, new BangladeshiWaterResource().getHeight());
        }

        [Fact]
        public void EgyptWaterSourceSizeTest()
        {
            Assert.Equal(12, new EgyptianWaterResource().getWidth());
            Assert.Equal(12, new EgyptianWaterResource().getHeight());
        }

        [Fact]
        public void EgyptTreeSizeTest()
        {
            Assert.Equal(16, new EgyptianTree().getWidth());
            Assert.Equal(24, new EgyptianTree().getHeight());
        }

        [Fact]
        public void BDTreeSizeTest()
        {
            Assert.Equal(16, new BangladeshiTree().getWidth());
            Assert.Equal(24, new BangladeshiTree().getHeight());
        }

    }
}
