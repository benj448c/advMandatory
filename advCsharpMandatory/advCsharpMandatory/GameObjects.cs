using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.Objects
{
    public abstract class GameObjects
    {
        public bool RemoveAble { get; set; }
        public bool LootAble { get; set; }
        public string Name { get; set; }
        public Position pos { get; set; }

        protected GameObjects(bool removeAble, bool lootAble, string name, Position pos)
        {
            RemoveAble = removeAble;
            LootAble = lootAble;
            Name = name;
            this.pos = pos;
        }
    }
}
