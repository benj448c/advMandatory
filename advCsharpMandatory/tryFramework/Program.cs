using System;
using advCsharpMandatory;
using advCsharpMandatory.Objects;
using tryFramework.objectCreator;

namespace tryFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            World world1 = new World(10 ,10);
            advCsharpMandatory.World.ObjectAndCreaturelist.Add(new Position(1,1) , new FriendlyBird());
            advCsharpMandatory.World.ObjectAndCreaturelist.Add(new Position(2,2), new Sword(true,true,"gude sværd"));
            world1.DrawWorld();
        }
    }
}
