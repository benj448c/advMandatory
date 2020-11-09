using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactory.Product;


namespace advCsharpMandatory.AbstractFactory
{
    public class Dragon : ICreature
    {
        public override IFriendly CreateFriendly()
        {
            return new FriendlyDragon();
        }

        public override IEnemy CreateEnemy()
        {
            return new EnemyDragon();
        }
    }
}
