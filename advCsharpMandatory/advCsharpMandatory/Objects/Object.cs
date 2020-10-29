using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class Object
    {
		private string _name;
		private bool _lootAble;
		private bool _removeAble;

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
