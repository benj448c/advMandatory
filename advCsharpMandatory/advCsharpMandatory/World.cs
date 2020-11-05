using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class World
    {
		private double _maxX;
		private double _maxY;
		private List<Position> _things;

        public List<Position> Things
		{
			get { return _things; }
			set { _things = value; }
		}

		public double MaxY
		{
			get { return _maxY; }
			set { _maxY = value; }
		}

		public double MaxX
		{
			get { return _maxX; }
			set { _maxX = value; }
		}

	}
}
