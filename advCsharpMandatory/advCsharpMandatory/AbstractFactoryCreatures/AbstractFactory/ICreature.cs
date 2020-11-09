using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public abstract class ICreature
    {
        public abstract IFriendly CreateFriendly();
        public abstract IEnemy CreateEnemy();
    }
}
