using System;
using System.Drawing;
using NUnit.Framework;

namespace MarsRoverTechnicalChallenge
{
    [TestFixture]
    class InterpreterTest
    {
        [Test]
        public void InterpreterStartingAtOriginGivenMReturnsZeroOne()
        {
            Point topRight = new Point(5, 5);
            Point start = new Point(0, 0);
            string instructions = "M";

            Point finish = Interpreter.Interpret(topRight, start, instructions);
            Point expected = new Point(0, 0);

            Assert.That(finish, Is.EqualTo(expected));
        }
    }
}
