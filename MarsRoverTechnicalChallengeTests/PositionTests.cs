using System;
using MarsRoverTechnicalChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTechnicalChallengeTests
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void PositionGivenZeroZeroNConstructsCorrectly()
        {
            var position = new Position(0, 0, Orientation.N);

            Assert.AreEqual(position.X, 0);
            Assert.AreEqual(position.Y, 0);
            Assert.AreEqual(position.Facing, Orientation.N);
        }

        [TestMethod]
        public void PositionGivenZeroZeroNRotatedRReturnsFacingE()
        {
            var position = new Position(0, 0, Orientation.N);
            position.Rotate(Direction.R);

            Assert.AreEqual(position.Facing, Orientation.E);
        }
    }
}
