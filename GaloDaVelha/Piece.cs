using System;
using System.Numerics;


namespace GaloDaVelha
{
    public class Piece
    {
        private PiecesChar chars;
        public Piece()
        {
            chars = 0;
        }  
        public void charModify(PiecesChar modifier)
        {
            chars ^= modifier;
        }
    }
}