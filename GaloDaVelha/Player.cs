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
            int [] pos = new int[2];
            bool error = false;

            if (input.Length != 2) error = true;

            if (input[0] == a) pos[0] = 0;
            else if (input[0] == b) pos[0] = 1;
            else if (input[0] == c) pos[0] = 2;
            else if (input[0] == d) pos[0] = 3;
            else error = true;

            if (0 >= ((int) input[1]) || ((int) input[1]) <= 3) pos[1] = (int) input[1];
            else error = true;

            if (error == true) LastPlaceInput[0] = -1;
            else LastPlaceInput = pos;
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