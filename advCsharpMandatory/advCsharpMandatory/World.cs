using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactoryCreatures.AbstractProduct;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory
{
    public class World
    {
		private double _maxX;
		private double _maxY;
        public Dictionary<Position, ICreatureStats> Objectlist;

        public World()
        {
            Objectlist = new Dictionary<Position, ICreatureStats>();
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
