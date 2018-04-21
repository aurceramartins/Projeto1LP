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
            Console.Clear();

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
            Console.WriteLine(" 1  2  3  4  5  6  7 \n");
        }
        private char PiecesName(Pieces pieces)
        {
            switch (pieces)
            {
                case Pieces.RedCircle: return 'r';
                case Pieces.RedCube: return 'R';
                case Pieces.WhiteCircle: return 'w';
                case Pieces.WhiteCube: return 'W';
                case Pieces.None: return '|';
                default: return ' ';
            }
        }
        public void Result(int win)
        {
            switch (win)
            {
                case 1: Console.WriteLine("PLAYER RED WINS!!"); break;
                case 2: Console.WriteLine("PLAYER WHITE WINS!!"); break;
                default: Console.WriteLine("Its a Draw!!"); break;
            }
        }
        public void Nplayer(int player)
        {
            switch (player)
            {
                case 1: Console.Write("PLAYER RED "); break;
                case 2: Console.Write("PLAYER WHITE "); break;
            }
        }
    }
}

