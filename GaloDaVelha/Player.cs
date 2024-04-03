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