using System;
using System.Numerics;


namespace GaloDaVelha
{
    public class Player
    {
        private PieceChar LastPieceInput;
        private int [] LastPlaceInput;
        private string name;
        public Player(string _name)
        {
            name = _name;
            LastPieceInput = 0;
            LastPlaceInput = new int [2];
        }  
        public void ConvertPieceInput(string input)
        {
            string[] wordChars = input.Split(' ');
            PieceChar chars = 0;
            bool error = false;

            if (chars[0] == "big" || chars[0] == "b") chars |= PiecesChar.BigOrSmall;
            else if (chars[0] == "small" || chars[0] == "s") chars &= ~PiecesChar.BigOrSmall;
            else error = true;

            if (chars[1] == "white" || chars[1] == "w") chars |= PiecesChar.WhiteOrBlack;
            else if (chars[1] == "black" || chars[1] == "b") chars &= ~PiecesChar.WhiteOrBlack;
            else error = true;

            if (chars[2] == "circle" || chars[2] == "c") chars |= PiecesChar.CircleOrSquare;
            else if (chars[2] == "square" || chars[2] == "s") chars &= ~PiecesChar.CircleOrSquare;
            else error = true;

            if (chars[3] == "hole" || chars[3] == "h") chars |= PiecesChar.HoleOrNoHole;
            else if (chars[3] == "nohole" || chars[3] == "n") chars &= ~PiecesChar.HoleOrNoHole;
            else error = true;

            if (error == true) LastPieceInput = -1;
            else LastPieceInput = chars;
        }
        public void ConvertPlaceInput(string input)
        {
            
        }
        public string GetName()
        {
            return name;
        }
        public PieceChar GetLastPieceInput()
        {
            return LastPieceInput;
        }
        public int [] GetLastPlaceInput()
        {
            return LastPlaceInput;
        }
    }
}