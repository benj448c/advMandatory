using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.Objects
{
    public abstract class GameObjects
    {
        public abstract bool RemoveAble { get; set; }
        public abstract bool LootAble { get; set; }
        public abstract string Name { get; set; }
        public abstract Position pos { get; set; }

        protected GameObjects(bool removeAble, bool lootAble, string name, Position pos)
        {
            RemoveAble = removeAble;
            LootAble = lootAble;
            Name = name;
            this.pos = pos;
        }
    }
}
