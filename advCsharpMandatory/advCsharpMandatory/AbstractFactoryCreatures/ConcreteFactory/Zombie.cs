using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public class Zombie : ICreature
    {
        public IFriendly CreateFriendly()
        {
            return new FriendlyZombie();
        }

        public IEnemy CreateEnemy()
        {
            return new EnemyZombie();
        }
    }
}
