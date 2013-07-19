using System;

namespace MarsRoverTechnicalChallenge
{
    enum Orientation { N, E, S, W };
    enum Direction { L, R };

    class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Orientation Facing { get; private set; }

        public Position(int x, int y, Orientation facing)
        {
            this.X = x;
            this.Y = y;
            this.Facing = facing;
        }

        public void Rotate(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
