using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.Objects
{
    public class AttackObject : GameObjects
    {
        public int Range { get; set; }
        public int Hitpoint { get; set; }

        public AttackObject(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }

        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }

    }
}
