using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactory.Product;

namespace advCsharpMandatory.AbstractFactory
{
    public class Dragon : ICreature
    {
        public IFriendly CreateFriendly()
        {
            return new FriendlyDragon();
        }

        public IEnemy CreateEnemy()
        {
            return new EnemyDragon();
        }
    }
}
