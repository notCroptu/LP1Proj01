using System;

namespace GaloDaVelha
{
    public class Piece
    {
        private PiecesChar chars;
        private string unicoded;

        public Piece()
        {
            chars = 0;
            unicoded = "0000";
        }

        public void charModify(PiecesChar modifier)
        {
            chars ^= modifier;
        }

        public void unicodedModify()
        {
            string unicodedBuilder = "";

            if ((chars & PiecesChar.BigOrSmall) != 0) unicodedBuilder += "\u25B2";
            else unicodedBuilder += "\u25B4";

            if ((chars & PiecesChar.WhiteOrBlack) != 0) unicodedBuilder += "\u2B1B";
            else unicodedBuilder += "\u2B1C";

            if ((chars & PiecesChar.CircleOrSquare) != 0) unicodedBuilder += "\u25CF";
            else unicodedBuilder += "\u2BC0";

            if ((chars & PiecesChar.HoleOrNoHole) != 0) unicodedBuilder += "\U0001F573";
            else unicodedBuilder += " ";

            unicoded = unicodedBuilder;
        }

        public string GetUnicoded()
        {
            return unicoded;
        }

        public PiecesChar GetChars()
        {
            return chars;
        }
    }
}