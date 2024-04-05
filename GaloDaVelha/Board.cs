using System;

namespace GaloDaVelha
{
    /// <summary>
    /// Making of the board
    /// </summary>
    public class Board
    {
        private int height;
        private int width;
        private Piece[] piecesLeft;
        private Piece[,] board;

        public Board()
        {
            height = 4;
            width = 4;
            piecesLeft = new Piece[height * width];
            board = new Piece[height, width];
            createPieces();
        }

        /// <summary>
        /// Creates all the pieces of the game inside the array piecesLeft, to be used later to render the board and choose pieces, etc
        /// </summary>
        public void createPieces()
        {
            for (int i = 0; i < piecesLeft.Length; i++)
            {
                // Creates a piece and adds it to piecesLeft
                piecesLeft[i] = new Piece();

                // Checks if the i is valid to give each piece their characteristic
                if (i % 2 == 0)
                {
                    piecesLeft[i].charModify(PiecesChar.BigOrSmall);
                }
                if ((i > 0 && i <= 2) || (i > 4 && i <= 8) || (i > 10 && i <= 12) || (i > 16 && i <= 18))
                {
                    piecesLeft[i].charModify(PiecesChar.WhiteOrBlack);
                }
                if ((i > 0 && i <= 4) || (i > 8 && i <= 12))
                {
                    piecesLeft[i].charModify(PiecesChar.CircleOrSquare);
                }
                if (i > 0 && i <= 8)
                {
                    piecesLeft[i].charModify(PiecesChar.HoleOrNoHole);
                }

                piecesLeft[i].unicodedModify();
            }
        }

        /// <summary>
        /// Visual Representation of the board
        /// </summary>
        public void Render()
        {
            Console.WriteLine("____ ____ ____ ____ ____");
            Console.WriteLine("|    | A  | B  | C  | D  |");
            for (int i = 0; i < height; i++)
            {
                Console.Write($"| {i}  |");
                for (int j = 0; j < width; j++)
                {
                    if (board[i, j] != null)
                    {
                        Console.Write($" {board[i, j].GetUnicoded()} |");
                    }
                    else
                    {
                        Console.Write("    |");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method accepts a piece chosen by a player and its coordinates,
        /// then puts the piece at those coordinates if they are free.
        /// </summary>
        /// <param name="_piece">This represent the chosen piece</param>
        /// <param name="coord">This are the (x,y) coordinates of the piece</param>
        public void PiecePlacer(PiecesChar _piece, int[] coord)
        {
            // Runs through all of piecesLeft array
            for (int i = 0; i < piecesLeft.Length; i++)
            {
                // Checks if the piece chosen is correspondent to a piece in piecesLeft 
                if (piecesLeft[i] != null && piecesLeft[i].GetChars() == _piece)
                {
                    // Puts the piece at the given coordinates
                    board[coord[0], coord[1]] = piecesLeft[i];

                    // The piece is "marked" as used
                    piecesLeft[i] = null;

                    break; // Exit the loop, which means that the move ends
                }
            }
        }

        public Piece[] GetpiecesLeft()
        {
            return piecesLeft;
        }

        public Piece[,] Getboard()
        {
            return board;
        }
    }
}