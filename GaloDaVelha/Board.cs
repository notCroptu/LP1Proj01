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
        public Piece [,] board;

        public Board(int received_height, int received_width)
        {
            height = received_height;
            width = received_width;
            
            board = new Piece [height, width];

        ///  Runs a cycle assuming the X valor
           for (int i = 0; i < board.GetLength(0); i++) 
            { 
                ///  Runs a cycle assuming the Y valor
                for (int j = 0; j < board.GetLength(1); j++) 
                { 
                    ///  Associates the valor of X and Y to the variable Board
                    board[i,j] = new Piece(i, j); 
                } 
            }
        }


        /// <summary>
        /// Visual Representation of the board
        /// </summary>
        public void Render()
        {
            foreach(Piece coordinate in board)
            {
                Console.WriteLine(coordinate.coordinate);
            }
            
        }
    }

}