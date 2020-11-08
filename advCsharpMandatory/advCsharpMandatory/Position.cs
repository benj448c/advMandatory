using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    public class Position
    {

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

		private double _position_X;
		private double _position_Y;

        public Position(double positionX, double positionY)
        {
            _position_X = positionX;
            _position_Y = positionY;
        }

		public double Position_Y
		{
			get { return _position_Y; }
			set { _position_Y = value; }
		}

        public double Position_X
		{
			get { return _position_X; }
			set { _position_X = value; }
		}

        public void Move(Direction direction)
        {
            if (direction == Direction.Up)
            {
                Position_X += 1;
            }
            if (direction == Direction.Left)
            {
                Position_X -= 1;
            }
            if (direction == Direction.Right)
            {
                Position_Y += 1;
            }
            if (direction == Direction.Down)
            {
                Position_Y -= 1;
            }
        }

	}
}
