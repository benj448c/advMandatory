using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class Position
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

	}
}
