using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class Object : Position
    {
		private string _name;
		private bool _lootAble;
		private bool _removeAble;

        public Object(double positionX, double positionY, string name, bool lootAble, bool removeAble) : base(positionX, positionY)
        {
            _name = name;
            _lootAble = lootAble;
            _removeAble = removeAble;
        }

		public bool RemoveAble
		{
			get { return _removeAble; }
			set { _removeAble = value; }
		}

        public bool LootAble
		{
			get { return _lootAble; }
			set { _lootAble = value; }
		}

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

	}
}
