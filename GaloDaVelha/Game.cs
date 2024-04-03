using System;

namespace GaloDaVelha
{
    class Game
    {
        private Board panel;
        private string input;
        private Player player1;
        private Player player2;
        private Player player;
        private int playerTurn;

        /// <summary>
        /// The constructor of the class Game creates instances of the necessary objects for the game
        /// </summary>
        public Game()
        {
            ///Criar aqui as instancias necessarias
            panel = new Board();
            input = "";
            playerTurn = 0;
        }

        /// <summary>
        /// This method is the game loop
        /// </summary>
        public void Start()
        {
            Console.Write("Input player 1's name: ")
            player1 = new Player(Console.ReadLine())
            Console.Write("Input player 2's name: ")
            player2 = new Player(Console.ReadLine())

            player = player1;

            while (true)
            {
                panel.Render();
                Console.WriteLine("Commands: exit/*size *colour *shape *hole/*placement     examples: 'big white square nohole' 'A0'")

                // o codigo que ve se um player ganhou deveria estar aqui, ja que o jogo deveria mostrar o render da ultima jogada antes de dar break

                Console.WriteLine("Player please input the next piece to be moved. ")
                input = Console.ReadLine();
                input = input.Lower();

                if (input == "exit") break;
                else
                {
                    player.ConvertPieceInput(input);
                    if (CheckInput(player.GetLastPieceInput())) return;

                    foreach (Piece piece in panel.piecesLeft)
                    {
                        if (player.GetLastPieceInput() == piece.GetChars())
                        {
                            
                            break;
                        }
                    }
                    switchPlayer()
                }

                Console.WriteLine("Player please input the positioning for . ")
                input = Console.ReadLine();
                input = input.Lower();

                if (input == "exit") break;
                else
                {
                    player.ConvertPlaceInput(input);
                    if (CheckInput(player.GetLastPlaceInput())) return;

                    //here goes the 

                    switchPlayer()
                }
            }
        }
        public void switchPlayer()
        {
            playerTurn ^= 1;
            if (playerTurn == 0)
            {
                player = player1;
            }
            else
            {
                player = player2;
            }
        }
        public bool CheckInput(PiecesChar input)
        {
            if (input == -1)
            {
                Console.WriteLine("Incorrect input.")
                return true; 
            }
            else return false;
        }
        public bool CheckInput(Int input)
        {
            if (input == -1)
            {
                Console.WriteLine("Incorrect input.")
                return true; 
            }
            else return false;
        }
    } 
}
