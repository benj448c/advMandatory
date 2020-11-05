using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class DefenceObject : Object
    {
		private double _bonusHP;
		private double _reduceHPTaken;

        public DefenceObject(double positionX, double positionY, string name, bool lootAble, bool removeAble, double bonusHp, double reduceHpTaken) : base(positionX, positionY, name, lootAble, removeAble)
        {
            _bonusHP = bonusHp;
            _reduceHPTaken = reduceHpTaken;
        }

		public double ReduceHPTaken
		{
			get { return _reduceHPTaken; }
			set { _reduceHPTaken = value; }
		}



		public double BonusHP
		{
			get { return _bonusHP; }
			set { _bonusHP = value; }
		}


	}
}
