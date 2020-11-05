using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class AttackObject : Object
    {
		private int _hitpoint;
		private int _range;

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
