using System;
using System.Collections.Generic;
using System.Text;

namespace advCsharpMandatory.AbstractFactory
{
    public class CreatureCreator
    {
        public CreatureCreator()
        {
            ICreature Zombie = new Zombie();
            client zombieClient = new client(Zombie);

            Console.WriteLine(zombieClient.GetEnemyCreatureDetails());
            Console.WriteLine(zombieClient.GetFriendlyCreatureDetails());

            //Creating Dragon
            ICreature Dragon = new Dragon();
            client dragonClient = new client(Dragon);

            //to get details of zombie
            Console.WriteLine(dragonClient.GetEnemyCreatureDetails());
            Console.WriteLine(dragonClient.GetFriendlyCreatureDetails());
        }
    }
}
