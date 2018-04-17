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

        public void ActualizeBoard(int playerElection, Pieces chosedPiece)
        {
            for (int i=0; i <= pieces.Length; i++)
            {
                if(pieces[i,playerElection] != Pieces.None)
                {
                    pieces[i, playerElection] = chosedPiece;
                }
            }
        }
    }
}
