using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class Creatures : Position
    {
        private double _HP = 100;
        private bool _alive = true;
        private double _damage;
        private AttackObject _attackObject;
        private DefenceObject _defenceObject;

        public Creatures(double positionX, double positionY, double damage) : base(positionX, positionY)
        {
            _damage = damage;
        }

        protected double Hit(Creatures target)
        {
            return _damage + _attackObject.Hitpoint;
        }

        protected void RecieveHit(double damageTaken)
        {
            _HP -= damageTaken;
            if (_HP < 0)
            {
                _alive = false;
            }
        }

        protected void PickUpAttackObject(AttackObject weapon)
        {
            _attackObject = weapon;
        }


        protected void PickUpDefenceObject(DefenceObject armor)
        {
            _defenceObject = armor;
        }

        public double HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public double Damage
        {
            get { return _damage; }
        }
    }
}
