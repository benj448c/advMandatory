using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory.AbstractFactory;

namespace tryFramework.CreateCreaturefolder
{
    class CreateBird : CreatureCreator
    {
        public override void CreateCreature()
        {
            ICreature Bird = new Bird();
            client birdClient = new client(Bird);

            Console.WriteLine(birdClient.GetEnemyCreatureDetails());
            Console.WriteLine(birdClient.GetFriendlyCreatureDetails());
        }
    }
}
