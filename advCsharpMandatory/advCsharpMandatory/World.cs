using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory
{
    public class World
    {
		private double _maxX;
		private double _maxY;
        public Dictionary<Position, GameObjects> Objectlist;

        public World()
        {
            Objectlist = new Dictionary<Position, GameObjects>();
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

        public void addObject(GameObjects thing)
        {
            if (!Objectlist.ContainsKey(thing.pos))
            {
                Objectlist.Add(thing.pos, thing);
            }
        }

        public void removeObject(GameObjects thing)
        {
            Objectlist.Remove(thing.pos);
        }
    }
}
