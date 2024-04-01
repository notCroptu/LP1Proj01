using System;
using System.Numerics;


namespace GaloDaVelha
{
    /// <summary>
    /// Creation of Class for the Pieces
    /// </summary>
    public class Piece
    {
       public string name;
       public Vector2 coordinate;

      public Piece(int x, int y)
      {
        name = "piece";
        /// Saving the coordinate of the positions (just to test, probably going to delete later)
        coordinate = new Vector2(x,y);
      }  
        
    }
}