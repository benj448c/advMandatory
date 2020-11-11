using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    public class Position
    {
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

        public void Move(CharacterDirection direction, bool moveable)
        {
            if (moveable)
            {
                if (direction.DirectionName == CharacterDirection._directionEnum.North)
                {
                    Position_X += 1;
                }
                if (direction.DirectionName == CharacterDirection._directionEnum.West)
                {
                    Position_X -= 1;
                }
                if (direction.DirectionName == CharacterDirection._directionEnum.East)
                {
                    Position_Y += 1;
                }
                if (direction.DirectionName == CharacterDirection._directionEnum.South)
                {
                    Position_Y -= 1;
                }
            }
        }
    }
}
