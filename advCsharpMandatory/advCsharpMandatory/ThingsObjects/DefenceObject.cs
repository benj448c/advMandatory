using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.Objects;

namespace advCsharpMandatory.Interfaces.DefenceObject
{
    public class DefenceObject : GameObjects
    {
        public int BonusHP { get; set; }
        public int ReduceHPTaken { get; set; }
        public string Type { get; set; }

        public DefenceObject(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }

        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
    }
}
