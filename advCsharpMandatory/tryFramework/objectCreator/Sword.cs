using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory;
using advCsharpMandatory.Objects;

namespace tryFramework.objectCreator
{
    class Sword: AttackObject
    {
        public Sword(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }
    }
}
