using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    /// <summary>
    /// Controller.
    /// </summary>
    class Controller
    {
        /// <summary>
        /// The board.
        /// </summary>
        Board board = new Board();
        /// <summary>
        /// The player1.
        /// </summary>
        Player player1 = new Player();
        /// <summary>
        /// The player2.
        /// </summary>
        Player player2 = new Player();
        /// <summary>
        /// The render.
        /// </summary>
        Render render = new Render();
        /// <summary>
        /// Check for the winner player.
        /// </summary>
        Check4Win isWinner = new Check4Win();

        /// <summary>
        /// Win
        /// </summary>
        private int win = 0;
        /// <summary>
        /// The turn.
        /// </summary>
        private int turn = 0;
        /// <summary>
        /// The player number.
        /// </summary>
        private int nplayer = 0;
        /// <summary>
        /// no more pieces verefier.
        /// </summary>
        private bool nopieces = false;
        /// <summary>
        /// player choose column.
        /// </summary>
        Position playerMove;
        /// <summary>
        /// player choose piece shape.
        /// </summary>
        Pieces pieceElected;
        /// <summary>
        /// Start Game
        /// </summary>
        public void Play()
        {
            ///Print the board
            render.RenderBoard(board);
            ///loop the game while there is more pieces to play or there is no 
            ///winner.
            while (nopieces == false && win == 0)
            {
                ///define player 1 turn.
                if (turn % 2 != 0)
                {
                    nplayer = 1;
                    ///print player 1 name.
                    render.Nplayer(nplayer);
                    ///player 1 choose the column to put the piece.
                    playerMove = player1.GetPosition(board);
                    ///player 1 choose the piece shape to put on the board.
                    pieceElected = player1.GetPlayerChosenPiece(board, nplayer);
                    ///put the defined piece in the board
                    board.SetBoard(playerMove, pieceElected);
                    ///set the player 2 turn
                    turn++;
                }
                ///define player 2 turn
                else
                {
                    nplayer = 2;
                    ///print player 2 name
                    render.Nplayer(nplayer);
                    ///player 2 choose the column to put the piece
                    playerMove = player2.GetPosition(board);
                    ///player 2 choose the piece shape to put on the board.
                    pieceElected = player2.GetPlayerChosenPiece(board, nplayer);
                    ///put the defined piece in the board
                    board.SetBoard(playerMove, pieceElected);
                    ///set the player 1 turn
                    turn++;
                }
                ///check if the selected column is full
                if (board.IsFullLine)
                {
                    ///the player repeat the turn
                    turn--;
                    ///set full column to false
                    board.IsFullLine = false;
                }
                ///Print the updated board
                render.RenderBoard(board);
                ///Verify if winner is true
                win = isWinner.Check(board, nplayer);
                ///Verify if there is player have pieces
                if (player1.Cube == 0 
                    && player1.Circle == 0
                    && player2.Circle == 0
                    && player2.Cube == 0) { nopieces = true; }
            }
            ///Prints if there is a winner
            render.Result(win);
        }
    }
}