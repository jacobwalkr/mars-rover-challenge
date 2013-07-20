using System;
using MarsRoverTechnicalChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTechnicalChallengeTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void RoverStartingAtZeroZeroNGivenLFacesW()
        {
            var start = new Position(0, 0, Orientation.N);
            var rover = new Rover(start);
            
            rover.Go("L");

            Assert.AreEqual(Orientation.W, rover.Position.Facing);
        }

        [TestMethod]
        public void RoverStartingAtZeroZeroNGivenRFacesE()
        {
            var start = new Position(0, 0, Orientation.N);
            var rover = new Rover(start);

            rover.Go("R");

            Assert.AreEqual(Orientation.E, rover.Position.Facing);
        }

        [TestMethod]
        public void RoverStartingAtZeroZeroNGivenMFinishesAtZeroOne()
        {
            var start = new Position(0, 0, Orientation.N);
            var rover = new Rover(start);

            rover.Go("M");

            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
        }

        [TestMethod]
        public void RoverStartingAtZeroZeroNGivenMRFinishesAtZeroOneFacingE()
        {
            var start = new Position(0, 0, Orientation.N);
            var rover = new Rover(start);

            rover.Go("MR");

            Assert.AreEqual(0, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
            Assert.AreEqual(Orientation.E, rover.Position.Facing);
        }

        [TestMethod]
        public void RoverStartingAtZeroZeroNGivenRMMLMFinishesAtTwoOneFacingN()
        {
            var start = new Position(0, 0, Orientation.N);
            var rover = new Rover(start);

            rover.Go("RMMLM");

            Assert.AreEqual(2, rover.Position.X);
            Assert.AreEqual(1, rover.Position.Y);
            Assert.AreEqual(Orientation.N, rover.Position.Facing);
        }
    }
}
