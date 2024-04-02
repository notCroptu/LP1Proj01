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
        private Piece [] piecesLeft;
        private Piece [,] board;

        public Board()
        {
            height = 4;
            width = 4;
            piecesLeft = new Piece [height*width];
            board = new Piece [height, width];
            createPieces();
        }
        /// <summary>
        /// Creates all the pieces of the game inside the array piecesLeft, to be used later to render the board and choose pieces, etc
        /// </summary>
        public void createPieces()
        {
            for (int i = 1; i <= piecesLeft.GetLength(0); i++)
            { 
                //  Creates a piece and adds it to piecesLeft
                piecesLeft[i] = new Piece();

                //  Checks if the i is valid to give each piece their characteristic
                if ( 0 == i%2 )
                {
                    piecesLeft[i].charModify(PiecesChar.BigOrSmall);
                }
                if ((0 < i & i <= 2) || (4 < i & i <= 8) || (10 < i & i <= 12) || (16 < i & i <= 18))
                {
                    piecesLeft[i].charModify(PiecesChar.WhiteOrBlack);
                }
                if ((0 < i & i <= 4) || (8 < i & i <= 12))
                {
                    piecesLeft[i].charModify(PiecesChar.CircleOrSquare);
                }
                if ( 0 < i & i <= 8 )
                {
                    piecesLeft[i].charModify(PiecesChar.HoleOrNoHole);
                }
            }
        }


        /// <summary>
        /// Visual Representation of the board
        /// </summary>
        public void Render()
        {
            string strBoard = "____ ____ ____ ____ ____";
            Console.WriteLine(strBoard);
            String.Format("|{0,-4}|{1,-4}|{2,-4}|{3,-4}|{4,-4}|", " ", "A", "B", "C", "D");
            for (int i = 0; i < board.Length; i++)
            {
                string strBoard = String.Format("|{0,-4}|{1,-4}|{2,-4}|{3,-4}|{4,-4}|", i.ToString(), row[0].GetUnicoded(), row[1].GetUnicoded(), row[2].GetUnicoded(), row[3].GetUnicoded());
                Console.WriteLine(strBoard);
            }
        }
    }

}