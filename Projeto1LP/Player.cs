using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Player
    {
        private Pieces chosenPiece;
        public Position GetPosition(Board board)
        {
            Console.WriteLine("Escolha onde quer jogar (1 a 7): ");
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);
            Console.WriteLine(desiredCoordinate);
            return desiredCoordinate;
        }
        private Position PositionForNumber(int position)
        {
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
        private Pieces ChoosePiece(int choose, int player)
        {
            if (player == 1)
            {
                switch (choose)
                {
                    case 1:
                        return Pieces.RedCube;
                        break;
                    case 2:
                        return Pieces.RedCircle;
                        break;
                }
            }
            else if (player == 2)
            {
                switch (choose)
                {
                    case 1:
                        return Pieces.WhiteCube;
                        break;
                    case 2:
                        return Pieces.WhiteCircle;
                        break;
                }
            }
            return chosenPiece;
        }
        public Pieces GetPlayerChosenPiece(Board board, int player)
        {
            Console.WriteLine("Escolha a peça: 1 - Cubo 2 - Cilindro");
            int choose = Convert.ToInt32(Console.ReadLine());
            Pieces desiredPieces = ChoosePiece(choose, player);
            Console.WriteLine(desiredPieces);
            return desiredPieces;
        }
    }
}
