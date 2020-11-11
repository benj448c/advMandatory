using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    class FriendlyZombie : IFriendly
    {
        public string GetCreatureDetails()
        {
            return "Friendly Zombie";
        }

        public int GetDamage()
        {
            return 10;
        }

        public int GetHP()
        {
            return 1000;
        }
    }
}
