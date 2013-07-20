using System;

namespace MarsRoverTechnicalChallenge
{
    public class Rover
    {
        public Position Position { get; private set; }

        public Rover(Position start)
        {
            this.Position = start;
        }

        public void Go(string instructions)
        {
            foreach (char instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        this.Position.Rotate(Direction.L);
                        break;

                    case 'R':
                        this.Position.Rotate(Direction.R);
                        break;

                    case 'M':
                        this.Position.Move();
                        break;
                }
            }
        }
    }
}
