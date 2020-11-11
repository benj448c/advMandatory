using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.interfaces;

namespace advCsharpMandatory.AbstractFactoryCreatures.AbstractProduct
{
    public interface ICreatureStats : IPosition
    {
        int GetDamage();
        int GetHP();
        string GetCreatureDetails();
    }
}
