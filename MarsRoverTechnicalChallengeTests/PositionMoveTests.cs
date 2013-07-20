using System;
using MarsRoverTechnicalChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTechnicalChallengeTests
{
    [TestClass]
    public class PositionMoveTests
    {
        [TestMethod]
        public void PositionGivenZeroZeroNMovedOnceReturnsZeroOneN()
        {
            var position = new Position(0, 0, Orientation.N);
            position.Move();

            Assert.AreEqual(0, position.X);
            Assert.AreEqual(1, position.Y);
            Assert.AreEqual(Orientation.N, position.Facing);
        }

        [TestMethod]
        public void PositionGivenZeroZeroEMovedOnceReturnsOneZeroE()
        {
            var position = new Position(0, 0, Orientation.E);
            position.Move();

            Assert.AreEqual(1, position.X);
            Assert.AreEqual(0, position.Y);
            Assert.AreEqual(Orientation.E, position.Facing);
        }

        [TestMethod]
        public void PositionGivenOneOneSMovedOnceReturnsOneZeroS()
        {
            var position = new Position(1, 1, Orientation.S);
            position.Move();

            Assert.AreEqual(1, position.X);
            Assert.AreEqual(0, position.Y);
            Assert.AreEqual(Orientation.S, position.Facing);
        }

        [TestMethod]
        public void PositionGivenOneOneWMovedOnceReturnsZeroOneW()
        {
            var position = new Position(1, 1, Orientation.W);
            position.Move();

            Assert.AreEqual(0, position.X);
            Assert.AreEqual(1, position.Y);
            Assert.AreEqual(Orientation.W, position.Facing);
        }
    }
}
