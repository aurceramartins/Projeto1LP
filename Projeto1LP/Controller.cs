using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Controller
    {
        Board board = new Board();
        Player player1 = new Player();
        Player player2 = new Player();
        Render render = new Render();
        Check4Win isWinner = new Check4Win();

        private int win = 0;
        private int turn = 0;
        private int nplayer = 0;
        private bool nopieces = false;
        Position playerMove;
        Pieces pieceElected;

        public void Play()
        {
            render.RenderBoard(board);

            while (nopieces == false && win == 0)
            {
                if (turn % 2 != 0)
                {
                    nplayer = 1;
                    render.Nplayer(nplayer);
                    playerMove = player1.GetPosition(board);
                    pieceElected = player1.GetPlayerChosenPiece(board, nplayer);
                    board.SetBoard(playerMove, pieceElected);
                    turn++;
                }
                else
                {
                    nplayer = 2;
                    render.Nplayer(nplayer);
                    playerMove = player2.GetPosition(board);
                    pieceElected = player2.GetPlayerChosenPiece(board, nplayer);
                    board.SetBoard(playerMove, pieceElected);
                    turn++;
                }
                if (board.IsFullLine)
                {
                    turn--;
                    board.IsFullLine = false;
                }
                render.RenderBoard(board);
                win = isWinner.Check(board, nplayer);
                if (player1.Cube == 0 && player1.Circle == 0 && player2.Circle == 0 && player2.Cube == 0) { nopieces = true; }
            }
            render.Result(win);
        }
    }
}