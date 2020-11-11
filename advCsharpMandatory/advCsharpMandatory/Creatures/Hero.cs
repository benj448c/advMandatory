using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactory;
using advCsharpMandatory.Interfaces.DefenceObject;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory.Creatures
{
    class Hero
    {
        private double _HP;
        private bool _alive = true;
        private double _damage;
        private AttackObject _attackObject;
        private Dictionary<DefenceObject, string> _defenceObject;
        private Position pos;

        public Hero(double hp, double damage, AttackObject attackObject, Dictionary<DefenceObject, string> defenceObject, Position pos)
        {
            _HP = hp;
            _damage = damage;
            _attackObject = attackObject;
            _defenceObject = defenceObject;
            this.pos = pos;
            
        }

        protected double Hit(ICreature target)
        {
            return _damage + _attackObject.Hitpoint;
        }

        protected void RecieveHit(double damageTaken)
        {
            double reducedDamage = 0;
            foreach (var defItem in _defenceObject)
            {
                reducedDamage += defItem.Key.ReduceHPTaken;
            }
            _HP -= damageTaken * (reducedDamage/10);
            if (_HP < 0)
            {
                _alive = false;
            }
        }

        protected void PickUpAttackObject(AttackObject weapon)
        {

            if (World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X + 1, pos.Position_Y)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X , pos.Position_Y + 1)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X - 1, pos.Position_Y)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X, pos.Position_Y - 1)))
            {
                if (weapon.LootAble)
                {
                    _attackObject = weapon;
                }
            }

        }

        protected void PickUpDefenceObject(DefenceObject armor)
        {
            if (World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X + 1, pos.Position_Y)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X, pos.Position_Y + 1)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X - 1, pos.Position_Y)) || World.ObjectAndCreaturelist.ContainsKey(new Position(pos.Position_X, pos.Position_Y - 1)))
            {
                if (armor.LootAble)
                {
                    if (!_defenceObject.ContainsValue(armor.Type))
                    {
                        _defenceObject.Add(armor, armor.Type);
                    }
                }
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
