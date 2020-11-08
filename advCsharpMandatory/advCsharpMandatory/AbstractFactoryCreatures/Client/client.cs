using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public class client
    {
        private IFriendly Friendly;
        private IEnemy Enemy;

        public client(ICreature factory)
        {
            Friendly = factory.CreateFriendly();
            Enemy = factory.CreateEnemy();
        }

        public string GetFriendlyCreatureDetails()
        {
            return Friendly.GetCreatureDetails();
        }

        public string GetEnemyCreatureDetails()
        {
            return Enemy.GetCreatureDetails();
        }

    }
}
