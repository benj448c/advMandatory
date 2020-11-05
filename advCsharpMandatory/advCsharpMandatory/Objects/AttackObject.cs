using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class AttackObject : Object
    {
		private int _hitpoint;
		private int _range;

        public AttackObject(double positionX, double positionY, string name, bool lootAble, bool removeAble, int hitpoint, int range) : base(positionX, positionY, name, lootAble, removeAble)
        {
            _hitpoint = hitpoint;
            _range = range;
        }

		public int Range
		{
			get { return _range; }
			set { _range = value; }
		}

		public int Hitpoint
		{
			get { return _hitpoint; }
			set { _hitpoint = value; }
		}
    }
}
