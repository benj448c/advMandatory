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

        protected void Hit(Creatures target)
        {
            
        }

        protected void RecieveHit()
        {

        }

        protected void PickUpObject(Object thing)
        {
            
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
