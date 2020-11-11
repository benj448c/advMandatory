using System;
using System.Collections.Generic;
using System.Text;
using advCsharpMandatory;
using advCsharpMandatory.interfaces;

namespace tryFramework
{
    class World : advCsharpMandatory.World
    {
        public World(int height, int width)
        {
            ObjectAndCreaturelist = new Dictionary<Position, IPosition>();
            _maxY = height;
            _maxY = width;
        }

        public override void DrawWorld()
        {

            for (int i = 0; i < _playground.GetLength(0); i++)
            {
                _playground[i, 0] = 'X';
                _playground[i, _playground.GetLength(1) - 1] = 'X';
                for (int j = 0; j < _playground.GetLength(1); j++)
                {
                    _playground[0, j] = 'X';
                    _playground[_playground.GetLength(0) - 1, j] = 'X';
                }
            }

            for (int i = 0; i <  _playground.GetLength(0); i++)
            {
                for (int j = 0; j < _playground.GetLength(1); j++)
                {
                    Console.Write(_playground[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
