using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public class Zombie : ICreature
    {
        public override IFriendly CreateFriendly()
        {
            return new FriendlyZombie();
        }

        public override IEnemy CreateEnemy()
        {
            return new EnemyZombie();
        }
    }
}
