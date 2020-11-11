using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory.Product
{
    class FriendlyDragon : IFriendly
    {
        public string GetCreatureDetails()
        {
            return "Friendly Dragon";
        }

        public int GetDamage()
        {
            return 100;
        }

        public int GetHP()
        {
            return 10000;
        }
    }
}
