using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.interfaces;

namespace advCsharpMandatory.Objects
{
    public abstract class GameObjects : IPosition
    {
        public abstract bool RemoveAble { get; set; }
        public abstract bool LootAble { get; set; }
        public abstract string Name { get; set; }

        protected GameObjects(bool removeAble, bool lootAble, string name)
        {
            RemoveAble = removeAble;
            LootAble = lootAble;
            Name = name;
        }
    }
}
