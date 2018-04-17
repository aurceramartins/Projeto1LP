using System;
namespace Projeto1LP
{
    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public Position(int column)
        {
            Column = column;
        }
    }
}
