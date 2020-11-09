using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.Objects
{
    public class AttackObject : GameObjects
    {
        public int Range { get; set; }
        public int Hitpoint { get; set; }

        public AttackObject(bool removeAble, bool lootAble, string name, Position pos, int range, int hitpoint) : base(removeAble, lootAble, name, pos)
        {
            Range = range;
            Hitpoint = hitpoint;
            RemoveAble = removeAble;
            LootAble = lootAble;
            Name = name;
            this.pos = pos;
        }

        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
        public override Position pos { get; set; }
    }
}
