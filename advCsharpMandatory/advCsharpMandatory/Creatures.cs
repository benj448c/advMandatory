using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory
{
    class Creatures
    {
        private double _HP;
        private double _damage;
        private List<AttackObject> _attackObject;
        private List<DefenceObject> _defenceObject;

        public Creatures(double hp, double damage, List<AttackObject> attackObject, List<DefenceObject> defenceObject)
        {
            _HP = hp;
            _damage = damage;
            _attackObject = attackObject;
            _defenceObject = defenceObject;
        }

        protected void Hit(Creatures target)
        {
            
        }

        protected void RecieveHit()
        {

        }

        protected void PickUpObject(Object thing)
        {
            if (expr)
            {
                
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
