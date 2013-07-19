using System;

namespace MarsRoverTechnicalChallenge
{
    class Rover
    {
        private Position start;
        private Position limit;

        public Rover(Position start, Position limit)
        {
            this.start = start;
            this.limit = limit;
        }

        public Position Go(string instructions)
        {
            throw new NotImplementedException();
        }
    }
}
