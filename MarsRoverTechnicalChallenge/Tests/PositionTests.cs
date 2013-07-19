using System;

namespace MarsRoverTechnicalChallenge
{
    [TestFixture]
    public class PositionTests
    {
        [Test]
        public void PositionGivenZeroZeroNConstructsCorrectly()
        {
            var position = new Position(0, 0, Orientation.N);

            Assert.AreEqual(position.X, 0);
            Assert.AreEqual(position.Y, 0);
            Assert.AreEqual(position.Facing, Orientation.N);
        }
    }
}
