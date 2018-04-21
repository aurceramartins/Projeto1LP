using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    /// <summary>
    /// Player.
    /// </summary>
    class Player
    {
        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        public Player()
        {
            Cube = 11;
            Circle = 10;
        }
        public int Cube { get; private set; }
        public int Circle { get; private set; }
        public Position GetPosition(Board board)
        {
            int position;
            Position desiredCoordinate;

            do
            {
                ///Prints the controlers intrutions
                Console.WriteLine("Escolha onde quer jogar (1 a 7): ");
                ///Convert the player input
                position = Convert.ToInt32(Console.ReadLine());
                ///sets the desired coordinate
                desiredCoordinate = PositionForNumber(position);
                ///Print a error if the desired column is not avaliable
                if (position > 7 || position <= 0) Console.WriteLine("Erro, escolhe outro número");
            } while (position > 7 || position <= 0);

            return desiredCoordinate;
        }
        /// <summary>
        /// Positions for number.
        /// </summary>
        /// <returns>The for number.</returns>
        /// <param name="position">Position.</param>
        private Position PositionForNumber(int position)
        {
            ///Returns the desired position
            switch (position)
            {
                case 1: return new Position(1);
                case 2: return new Position(2);
                case 3: return new Position(3);
                case 4: return new Position(4);
                case 5: return new Position(5);
                case 6: return new Position(6);
                case 7: return new Position(7);

                default: return null;
            }
        }
        /// <summary>
        /// Gets the player chosen piece.
        /// </summary>
        /// <returns>The player chosen piece.</returns>
        /// <param name="board">Board.</param>
        /// <param name="player">Player.</param>
        public Pieces GetPlayerChosenPiece(Board board, int player)
        {
            
            int choose;
            Pieces desiredPieces;
            Console.WriteLine("cubos; "+ Cube + " circulos; " + Circle);

            do
            {
                Console.WriteLine("Escolha a peça: 1 - Cubo 2 - Cilindro");
                choose = Convert.ToInt32(Console.ReadLine());

                if (Cube == 0) choose = 2;
                else if (Circle == 0) choose = 1;

                desiredPieces = ChoosePiece(choose, player);
                Console.WriteLine(desiredPieces);
                if ((choose > 2 || choose <= 0)) Console.WriteLine("Erro volta a escolher");
            } while (choose > 2 || choose <= 0);
            switch (choose)
            {
                case 1:
                    Cube--;
                    break;
                case 2:
                    Circle--;
                    break;
            }
            return desiredPieces;
        }
        /// <summary>
        /// Chooses the piece.
        /// </summary>
        /// <returns>The piece.</returns>
        /// <param name="choose">Choose.</param>
        /// <param name="player">Player.</param>
        private Pieces ChoosePiece(int choose, int player)
        {
            if (player == 1)
            {
                switch (choose)
                {
                    case 1: return Pieces.RedCube;
                    case 2: return Pieces.RedCircle;
                    default: return Pieces.None;
                }
            }
            else
            {
                switch (choose)
                {
                    case 1: return Pieces.WhiteCube;
                    case 2: return Pieces.WhiteCircle;
                    default: return Pieces.None;
                }
            }
        }
    }
}
