using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using advCsharpMandatory.AbstractFactoryCreatures.AbstractProduct;
using advCsharpMandatory.interfaces;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory
{
    public abstract class World
    {
		protected static int _maxX; 
        protected static int _maxY;
        public static Dictionary<Position, IPosition> ObjectAndCreaturelist;
        protected char[,] _playground = new char[_maxY, _maxX];



        public int MaxY
		{
			get { return _maxY; }
			set { _maxY = value; }
		}

		public int MaxX
		{
			get { return _maxX; }
			set { _maxX = value; }
		}

        public abstract void DrawWorld();

        public void GetAllWeapons()
        {
            var weapons = ObjectAndCreaturelist.Select(i => i.Value).Where(d => d.GetType() == typeof(AttackObject));
        }

    }
}
