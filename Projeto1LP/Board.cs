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

        public Pieces Board { get; private set; }; 
    }
}
