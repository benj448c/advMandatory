using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactoryCreatures.AbstractProduct;

namespace advCsharpMandatory.AbstractFactory
{
    public interface IFriendly : ICreatureStats
    {
        string GetCreatureDetails();
    }
}
