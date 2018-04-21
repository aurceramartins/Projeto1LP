using System;
namespace Projeto1LP
{
    /// <summary>
    /// Board.
    /// </summary>
    public class Board
    {
        /// <summary>
        /// The pieces.
        /// </summary>
        private Pieces[,] pieces;
        /// <summary>
        /// Initializes a new instance of the Board class.
        /// </summary>
        public Board()
        {
            ///Initialize pieces array
            pieces = new Pieces[7, 7];
            ///initialize full column verifier
            IsFullLine = false;
        }
        /// <summary>
        /// Gets or sets a value indicating whether the line is full.
        /// </summary>
        /// <value><c>true</c> if is full line; otherwise, <c>false</c>.</value>
        public bool IsFullLine { get; set; }
        /// <summary>
        /// Gets the board.
        /// </summary>
        /// <returns>The board.</returns>
        /// <param name="position">Position.</param>
        public Pieces GetBoard(Position position)
        {
            ///returns board positions
            return pieces[position.Row, position.Column];
        }
        /// <summary>
        /// Sets the board.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <param name="choosedPiece">Choosed piece.</param>
        public void SetBoard(Position position, Pieces choosedPiece)
        {
            ///go throught the board columns
            for (int i = 6; i >= 0; i--)
            {
                ///if the position is empty
                if (pieces[i, position.Column - 1] == Pieces.None)
                {
                    ///Puts the pieces to the bottom of the board
                    pieces[i, position.Column - 1] = choosedPiece;
                    break;
                }
                ///if a column is full of pieces
                else if (i == 0 && pieces[i, position.Column - 1] != Pieces.None)
                {
                    ///board column is full
                    IsFullLine = true;
                }
            }
        }
    }
}