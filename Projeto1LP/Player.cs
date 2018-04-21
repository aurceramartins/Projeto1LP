using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto1LP
{
    class Player
    {
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
                Console.WriteLine("Escolha onde quer jogar (1 a 7): ");
                position = Convert.ToInt32(Console.ReadLine());
                desiredCoordinate = PositionForNumber(position);
                if (position > 7 || position <= 0) Console.WriteLine("Erro volva a escolher");
            } while (position > 7 || position <= 0);

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
        public Pieces GetPlayerChosenPiece(Board board, int player)
        {
            int choose;
            Pieces desiredPieces;
            Console.WriteLine(Cube + " cubos , circulos " + Circle);

            do
            {
                Console.WriteLine("Escolha a peça: 1 - Cubo 2 - Cilindro");
                choose = Convert.ToInt32(Console.ReadLine());

                if (Cube == 0) choose = 2;
                else if (Circle == 0) choose = 1;

                desiredPieces = ChoosePiece(choose, player);
                Console.WriteLine(desiredPieces);
                if ((choose > 2 || choose <= 0)) Console.WriteLine("Erro volva a escolher");
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
