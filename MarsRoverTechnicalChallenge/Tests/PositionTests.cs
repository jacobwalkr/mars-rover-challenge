using System;
using NUnit.Framework;

namespace MarsRoverTechnicalChallenge.Tests
{
    [TestFixture]
    class PositionTests
    {
        [Test]
        public void PositionGivenZeroZeroNConstructsCorrectly()
        {
            var position = new Position(0, 0, Position.Orientation.N);

            Assert.That(position.X, Is.EqualTo(0));
            Assert.That(position.Y, Is.EqualTo(0));
            Assert.That(position.Facing, Is.EqualTo(Position.Orientation.N));
        }
    }
}
