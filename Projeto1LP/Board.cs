using System;
namespace Projeto1LP
{
    public class Board
    {
        private Pieces[,] pieces;

        public Board()
        {
            pieces = new Pieces[7, 7];
        }

        public Pieces GetBoard(Position position)
        {
            return pieces[position.Row, position.Column];
        }

        public void SetBoard(Position position, Pieces choosedPiece)
        {
            for (int i = 6; i >= 0; i--)
            {
                if (pieces[i, position.Column-1] == Pieces.None)
                {
                    pieces[i, position.Column-1] = choosedPiece;
                    break;
                }
            }
        }
    }
}
