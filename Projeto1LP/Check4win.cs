using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Check4Win
    {
        public void CheckWinner(Board board)
        {
            char[,] symbols = new char[7, 7];

            for (int i = 6; i >= 0; i--)
            {
                for (int j = 6; j >= 0; j--)
                {
                    symbols[i, j] = PiecesName(board.GetBoard(new Position(i, j)));
                }
            }

            for (int i = 6; i >= 0; i--)
            {
                for (int j = 6; j >= 0; j--)
                {
                    if (symbols[i, j] != '|')
                    {
                        if (j >= 3)
                        {
                            //   for (int p = 1; p <= ; p++)
                            //   {
                            if (symbols[i, j] == symbols[i, j - 1] && symbols[i, j] == symbols[i, j - 2] && symbols[i, j] == symbols[i, j - 3])
                            {
                                Console.WriteLine("GANHEIIIIIIIIIIII");
                            }
                            //  }
                        }
                        else if (i >= 3)
                        {
                            if (symbols[i, j] == symbols[i - 1, j] && symbols[i, j] == symbols[i - 2, j] && symbols[i, j] == symbols[i - 3, j])
                            {
                                Console.WriteLine("GANHEIIIIIIIIIIII");
                            }
                        }
                        if (i >= 3 && j >= 3)
                        {
                            if (symbols[i, j] == symbols[i - 1, j - 1] && symbols[i, j] == symbols[i - 2, j - 2] && symbols[i, j] == symbols[i - 3, j - 3])
                            {
                                Console.WriteLine("GANHEIIIIIIIIIIIINASDIAGONAISMAIS");
                            }
                        }
                        if (i >= 3 && j <= 3)
                        {
                            if (symbols[i, j] == symbols[i - 1, j + 1] && symbols[i, j] == symbols[i - 2, j + 2] && symbols[i, j] == symbols[i - 3, j + 3])
                            {
                                Console.WriteLine("GANHEIIIIIIIIIIIINASDIAGONAISMENOS");
                            }
                        }
                    }
                }
            }
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
    }
}
