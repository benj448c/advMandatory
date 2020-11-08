using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.Interfaces.DefenceObject;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory
{
    public class Creaturess : Position
    {
        private double _HP = 100;
        private bool _alive = true;
        private double _damage;
        private AttackObject _attackObject;
        private DefenceObject _defenceObject;

        public Creaturess(double positionX, double positionY, double damage) : base(positionX, positionY)
        {
            _damage = damage;
        }

        protected double Hit(Creaturess target)
        {
            return _damage + _attackObject.Hitpoint;
        }

        protected void RecieveHit(double damageTaken)
        {
            _HP -= damageTaken * _defenceObject.ReduceHPTaken;
            if (_HP < 0)
            {
                _alive = false;
            }
        }

        protected void PickUpAttackObject(AttackObject weapon)
        {
            if (weapon.LootAble)
            {
                _attackObject = weapon;
            }
        }


        protected void PickUpDefenceObject(DefenceObject armor)
        {
            if (armor.LootAble)
            { 
                _defenceObject = armor;   
            }
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
