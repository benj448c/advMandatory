using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory.Product
{
    class EnemyDragon : IEnemy
    {
        public string GetCreatureDetails()
        {
            return "Enemy Dragon";
        }

        public int GetDamage()
        {
            return 120;
        }

        public int GetHP()
        {
            return 10000;
        }
    }
}
