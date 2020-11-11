using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactory;
using tryFramework.CreateCreature;

namespace tryFramework.CreateCreaturefolder
{
    class Bird : ICreature
    {
        public override IFriendly CreateFriendly()
        {
            return new FriendlyBird();
        }

        public override IEnemy CreateEnemy()
        {
            return new EnemyBird();
        }
    }
}
