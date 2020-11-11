using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory;
using advCsharpMandatory.AbstractFactory;

namespace tryFramework.CreateCreature
{
    class EnemyBird : IEnemy
    {
        public int GetDamage()
        {
            return 10;
        }

        public int GetHP()
        {
            return 10;
        }

        public string GetCreatureDetails()
        {
            return "Enemy Bird";
        }
    }
}
