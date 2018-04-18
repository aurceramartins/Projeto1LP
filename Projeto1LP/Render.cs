using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Render
    {
        char[,] symbols = new char[7, 7];
        public void RenderBoard(Board board)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    symbols[i, j] = PiecesName(board.GetBoard(new Position(i, j)));

                    Console.Write($" {symbols[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("---------------------");
        }
        private char PiecesName(Pieces pieces)
        {
            switch (pieces)
            {
                case Pieces.RedCircle: return 'r';
                case Pieces.RedCube: return 'R';
                case Pieces.WhiteCircle: return 'w';
                case Pieces.WhiteCube: return 'W';
                case Pieces.None:return '|';
                default: return ' ';
            }
        }

    }
}