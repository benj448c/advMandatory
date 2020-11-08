using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public interface ICreature
    {
        IFriendly CreateFriendly();
        IEnemy CreateEnemy();
    }
}
