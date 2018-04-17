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

        private int turn = 0;
        private int nplayer = 0;

        public void Play()
        {
            while (true)
            {
                //renderer.Renderer();
                if (turn % 2 != 0)
                {
                    nplayer = 1;
                    Position playerMove = player1.GetPosition(board);
                    Pieces pieceElected = player1.GetPlayerChosenPiece(board, nplayer);

                    board.ActualizeBoard(playerMove, pieceElected);
                    //renderer.Renderer();
                    //renderer.RenderResults();
                    turn++;
                }
                else
                {
                    nplayer = 2;
                    Position playerMove = player2.GetPosition(board);
                    Pieces pieceElected = player2.GetPlayerChosenPiece(board, nplayer);

                    board.ActualizeBoard(playerMove, pieceElected);
                    //renderer.Renderer();
                    //renderer.RenderResults();
                    turn++;
                }
            }
        }
    }
}