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

        public Pieces AllBoard { get; private set; }

        public void ActualizeBoard(Position position, Pieces chosedPiece)
        {
            for (int i=0; i <= pieces.Length; i++)
            {
                if(pieces[i,position.Column] != Pieces.None)
                {
                    pieces[i, position.Column] = chosedPiece;
                }
            }
        }
    }
}
