using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory
{
    class TerrainObject : GameObjects
    {
        public TerrainObject(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }
        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
    }
}
