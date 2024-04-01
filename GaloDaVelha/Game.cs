using System;

namespace GaloDaVelha
{
    class Game
    {
        /// <summary>
        /// The constructor of the class Game creates instances of the necessary objects for the game
        /// </summary>
        public Game()
        {
            ///Criar aqui as instancias necessarias
        }
        /// <summary>
        /// This method is the game loop
        /// </summary>
        public void Start()
        {
            Board panel = new Board(4,4);
            while (true)
            {
                /// Printing the Board and using a "Console.ReadLine" to control the cycle
                panel.Render();
                Console.ReadLine();
            }
            
        }
    } 
}
