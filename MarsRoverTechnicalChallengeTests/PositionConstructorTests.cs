using System;
using MarsRoverTechnicalChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTechnicalChallengeTests
{
    [TestClass]
    public class PositionConstructorTests
    {
        [TestMethod]
        public void PositionGivenZeroZeroNConstructsCorrectly()
        {
            var position = new Position(0, 0, Orientation.N);

            Assert.AreEqual(position.X, 0);
            Assert.AreEqual(position.Y, 0);
            Assert.AreEqual(Orientation.N, position.Facing);
        }

        [TestMethod]
        public void PositionGivenFiveFiveSConstructsCorrectly()
        {
            var position = new Position(5, 5, Orientation.S);

            Assert.AreEqual(position.X, 5);
            Assert.AreEqual(position.Y, 5);
            Assert.AreEqual(Orientation.S, position.Facing);
        }
    }
}
