using System;

namespace GaloDaVelha
{
    class Game
    {
        private Board panel;

        /// <summary>
        /// The constructor of the class Game creates instances of the necessary objects for the game
        /// </summary>
        public Game()
        {
            ///Criar aqui as instancias necessarias
            panel = new Board();
        }
        /// <summary>
        /// This method is the game loop
        /// </summary>
        
        public void Start()
        {
            while (true)
            {
                /// Printing the Board and using a "Console.ReadLine" to control the cycle
                panel.Render();
                Console.ReadLine();
            }
            
        }
    } 
}
