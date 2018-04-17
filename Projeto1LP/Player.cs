using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Player
    {

        public Position GetPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);
            return desiredCoordinate;
        }

        private Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(1);
                case 2: return new Position(2);
                case 3: return new Position(3);
                case 4: return new Position(4);
                case 5: return new Position(5);
                case 6: return new Position(6); 
                case 7: return new Position(7); 
              
                default: return null;
            }
        }
    }
}
