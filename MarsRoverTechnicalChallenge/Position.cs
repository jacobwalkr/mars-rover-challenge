using System;

namespace MarsRoverTechnicalChallenge
{
    class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Facing { get; private set; }

        public Position(int x, int y, char facing)
        {
            this.X = x;
            this.Y = y;
            this.Facing = facing;
        }

        public Rotate(char direction)
        {
            throw new NotImplementedException();
        }
    }
}
