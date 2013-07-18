using System;
using System.Drawing;

namespace MarsRoverTechnicalChallenge
{
    class Rover
    {
        private Point start;
        private Point limit;

        public Rover(Point start, Point limit)
        {
            this.start = start;
            this.limit = limit;
        }

        public Point Go(string instructions)
        {
            throw new NotImplementedException();
        }
    }
}
