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
            string[] words = input.Split(' ');
            PieceChar chars = 0;
            bool error = false;

            if (words[0] == "big" || words[0] == "b") chars |= PiecesChar.BigOrSmall;
            else if (words[0] == "small" || words[0] == "s") chars &= ~PiecesChar.BigOrSmall;
            else error = true;

            if (words[1] == "white" || words[1] == "w") chars |= PiecesChar.WhiteOrBlack;
            else if (words[1] == "black" || words[1] == "b") chars &= ~PiecesChar.WhiteOrBlack;
            else error = true;

            if (words[2] == "circle" || words[2] == "c") chars |= PiecesChar.CircleOrSquare;
            else if (words[2] == "square" || words[2] == "s") chars &= ~PiecesChar.CircleOrSquare;
            else error = true;

            if (words[3] == "hole" || words[3] == "h") chars |= PiecesChar.HoleOrNoHole;
            else if (words[3] == "nohole" || words[3] == "n") chars &= ~PiecesChar.HoleOrNoHole;
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
        public string GetName() => name;
        public PieceChar GetLastPieceInput() => LastPieceInput;
        public int [] GetLastPlaceInput() => LastPlaceInput;
        
    }
}