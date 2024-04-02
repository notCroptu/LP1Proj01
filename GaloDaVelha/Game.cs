using System;

namespace GaloDaVelha
{
    class Game
    {
        private Board panel;
        private string input;

        /// <summary>
        /// The constructor of the class Game creates instances of the necessary objects for the game
        /// </summary>
        public Game()
        {
            ///Criar aqui as instancias necessarias
            panel = new Board();
            input = "";
        }

        /// <summary>
        /// This method is the game loop
        /// </summary>
        public void Start()
        {
            while (true)
            {
                panel.Render();
                Console.WriteLine("Commands: exit/*size *colour *shape *hole/*placement     examples: 'big white square nohole' 'A0'")

                // o codigo que ve se um player ganhou deveria estar aqui, ja que o jogo deveria mostrar o render da ultima jogada antes de dar break

                Console.WriteLine("Player please input the next piece to be moved. ")
                input = Console.ReadLine();
                input = input.Lower();

                if (input == "exit") break;
                else if ()

                Console.WriteLine("Player please input the next piece to be moved. ")
                input = Console.ReadLine();
                input = input.Lower();

                if (input == "exit") break;
                else if ()

            }
            
        }
    } 
}
