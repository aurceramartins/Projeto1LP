using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    /// <summary>
    /// Render.
    /// </summary>
    class Render
    {
        /// <summary>
        /// The symbols array.
        /// </summary>
        char[,] symbols = new char[7, 7];
        /// <summary>
        /// Renders the board.
        /// </summary>
        /// <param name="board">Board.</param>
        public void RenderBoard(Board board)
        {
            ///clean the command line
            Console.Clear();
            ///Go through the lines array
            for (int i = 0; i < 7; i++)
            {
                ///Go through the columns array
                for (int j = 0; j < 7; j++)
                {
                    ///Saves the board positions in the symbols array
                    symbols[i, j] = PiecesName(board.GetBoard(new Position(i, j)));
                    ///prints the board
                    Console.Write($" {symbols[i, j]} ");
                }
                Console.Write("\n");
            }
            ///prints the lower board part 
            Console.WriteLine("---------------------");
            Console.WriteLine(" 1  2  3  4  5  6  7 \n");
        }
        /// <summary>
        /// Diferent pieces.
        /// </summary>
        /// <returns>The name.</returns>
        /// <param name="pieces">Pieces.</param>
        private char PiecesName(Pieces pieces)
        {
            ///print the choosed pieces
            switch (pieces)
            {
                case Pieces.RedCircle: return 'r';
                case Pieces.RedCube: return 'R';
                case Pieces.WhiteCircle: return 'w';
                case Pieces.WhiteCube: return 'W';
                ///No piece
                case Pieces.None: return '|';
                default: return ' ';
            }
        }
        /// <summary>
        /// Result the specified winner.
        /// </summary>
        /// <returns>The result.</returns>
        /// <param name="win">Window.</param>
        public void Result(int win)
        {
            switch (win)
            {
                case 1: Console.WriteLine("JOGADOR VERMELHO GANHA!!"); break;
                case 2: Console.WriteLine("JOGADOR BRANCO GANHA!!"); break;
                default: Console.WriteLine("EMPATE!!"); break;
            }
        }
        /// <summary>
        /// prints the player turn
        /// </summary>
        /// <returns>The nplayer.</returns>
        /// <param name="player">Player.</param>
        public void Nplayer(int player)
        {
            switch (player)
            {
                case 1: Console.WriteLine("JOGADOR VERMELHO"); break;
                case 2: Console.WriteLine("JOGADOR BRANCO"); break;
            }
        }
    }
}

