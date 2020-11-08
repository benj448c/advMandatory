using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    class EnemyZombie : IEnemy
    {
        public string GetCreatureDetails()
        {
            return "Enemy Zombie";
        }

        public int GetDamage()
        {
            return 10;
        }

        public int GetHP()
        {
            return 1000;
        }
    }
}
