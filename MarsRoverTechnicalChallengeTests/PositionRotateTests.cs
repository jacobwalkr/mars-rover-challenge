using System;
using MarsRoverTechnicalChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTechnicalChallengeTests
{
    [TestClass]
    public class PositionRotateTests
    {
        [TestMethod]
        public void PositionGivenZeroZeroNRotatedRFacesE()
        {
            var position = new Position(0, 0, Orientation.N);
            position.Rotate(Direction.R);

            Assert.AreEqual(Orientation.E, position.Facing);
        }

        [TestMethod]
        public void PositionGivenZeroZeroSRotatedLFacesE()
        {
            var position = new Position(0, 0, Orientation.S);
            position.Rotate(Direction.L);

            Assert.AreEqual(Orientation.E, position.Facing);
        }

        [TestMethod]
        public void PositionGivenZeroZeroNRotatedRRRRFacesN()
        {
            var position = new Position(0, 0, Orientation.N);

            for (int i = 0; i < 4; i++)
            {
                position.Rotate(Direction.R);
            }

            Assert.AreEqual(Orientation.N, position.Facing);
        }

        [TestMethod]
        public void PositionGivenZeroZeroWRotatedLLLLFacesW()
        {
            var position = new Position(0, 0, Orientation.W);

            for (int i = 0; i < 4; i++)
            {
                position.Rotate(Direction.L);
            }

            Assert.AreEqual(Orientation.W, position.Facing);
        }
    }
}
