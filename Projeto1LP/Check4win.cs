using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Check4Win
    {
        public int Check(Board board, int nplayer)
        {
            if (CheckWinner(board, nplayer)) return nplayer;
            else return 0;
        }
        public bool CheckWinner(Board board, int nplayer)
        {
            for (int i = 6; i >= 0; i--)
            {
                for (int j = 6; j >= 0; j--)
                {
                    if (j >= 3)
                    {
                        if (CheckBoard(board, new Position[] {
                        new Position(i, j),
                        new Position(i, j-1),
                        new Position(i, j-2),
                        new Position(i, j-3) }, nplayer))
                        {
                            return true;
                        }
                    }
                    else if (i >= 3)
                    {
                        if (CheckBoard(board, new Position[] {
                        new Position(i, j),
                        new Position(i-1, j),
                        new Position(i-2, j),
                        new Position(i-3, j) }, nplayer))
                        {
                            return true;
                        }
                    }
                    if (i >= 3 && j >= 3)
                    {
                        if (CheckBoard(board, new Position[] {
                        new Position(i, j),
                        new Position(i-1, j-1),
                        new Position(i-2, j-2),
                        new Position(i-3, j-3) }, nplayer))
                        {
                            return true;
                        }
                    }
                    if (i >= 3 && j <= 3)
                    {
                        if (CheckBoard(board, new Position[] {
                        new Position(i, j),
                        new Position(i-1, j+1),
                        new Position(i-2, j+2),
                        new Position(i-3, j+3) }, nplayer))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckBoard(Board board, Position[] positions, int nplayer)
        {
            int white = 0;
            int cube = 0;
            int circle = 0;
            int red = 0;

            foreach (Position position in positions)
            {
                if (board.GetBoard(position) == Pieces.RedCircle
                    || board.GetBoard(position) == Pieces.RedCube)
                {
                    if (red == 3)
                    {
                        if (nplayer == 1)
                        {
                            red = 0;
                            return true;
                        }
                    }
                    red++;
                }
                else
                {
                    red = 0;
                }
                if (board.GetBoard(position) == Pieces.RedCube
                    || board.GetBoard(position) == Pieces.WhiteCube)
                {
                    if (cube == 3)
                    {
                        if (nplayer == 1)
                        {
                            cube = 0;
                            return true;
                        }
                    }
                    cube++;
                }
                else
                {
                    cube = 0;
                }
                if (board.GetBoard(position) == Pieces.WhiteCircle
                    || board.GetBoard(position) == Pieces.RedCircle)
                {
                    if (nplayer == 2)
                    {
                        if (circle == 3)
                        {
                            circle = 0;
                            return true;
                        }
                    }
                    circle++;
                }
                else
                {
                    circle = 0;
                }
                if (board.GetBoard(position) == Pieces.WhiteCube
                    || board.GetBoard(position) == Pieces.WhiteCircle)
                {
                    if (white == 3)
                    {
                        if (nplayer == 2)
                        {
                            white = 0;
                            return true;
                        }
                    }
                    white++;
                }
                else
                {
                    white = 0;
                }
            }
            return false;
        }
    }
}
