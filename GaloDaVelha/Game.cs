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
        private Player piecePlayer;
        private int playerTurn;

        /// <summary>
        /// The constructor of the class Game creates instances of the necessary objects for the game
        /// </summary>
        public Game()
        {
            panel = new Board();
            input = "";
            playerTurn = 0;
        }

        /// <summary>
        /// This method is the game loop
        /// </summary>
        public void Start()
        {
            Console.Write("Input player 1's name: ");
            player1 = new Player(Console.ReadLine());
            Console.Write("Input player 2's name: ");
            player2 = new Player(Console.ReadLine());

            piecePlayer = player2;
            player = player1;

            while (true)
            {
                // the panel is rendered here
                panel.Render();
                //followed by some instructions
                Console.WriteLine("Commands: exit/*size *colour *shape *hole/*placement     examples: 'big white square nohole' 'A0'");

                // o codigo que ve se um player ganhou deveria estar aqui, ja que o jogo deveria mostrar o render da ultima jogada antes de dar break

                Console.WriteLine($"{player}, please input the next piece to be moved. ");
                input = Console.ReadLine();
                input = input.ToLower();

                while (true)
                {
                    if (input == "exit") break;
                    else
                    {
                        // here the input is converted either into a PiecesChar or an int -1 (false or true)
                        player.ConvertPieceInput(input);
                        //here goes the checker to make sure the input is correct
                        if (CheckInput(player.GetLastPieceInput())) return;
                        else break;
                    }
                }

                switchPlayer();

                Console.WriteLine($"{player}, please input the positioning for the piece {ToPieceUnicoded(piecePlayer.GetLastPieceInput())}. ");
                input = Console.ReadLine();
                input = input.ToLower();

                while (true)
                {
                    if (input == "exit") break;
                    else
                    {
                        // here the input is converted either into an int[2] or an int -1 (false or true)
                        player.ConvertPlaceInput(input);
                        // here goes the checker to make sure the input is correct
                        if (CheckInput(player.GetLastPlaceInput())) return;
                        else break;
                    }
                }

                //here the piece should be set in panel
                panel.PiecePlacer(piecePlayer.GetLastPieceInput(), player.GetLastPlaceInput());
            }
        }

        public void switchPlayer()
        {
            playerTurn ^= 1;
            if (playerTurn == 0)
            {
                player = player1;
                piecePlayer = player2;
            }
            else
            {
                player = player2;
                piecePlayer = player1;
            }
        }

        public bool CheckInput(PiecesChar input)
        {
            bool result;
            if (input == PiecesChar.Invalid)
            {
                Console.WriteLine("Incorrect input.");
                result = true;
            }
            else result = false;
            return result;
        }

        public bool CheckInput(int[] input)
        {
            bool result;
            if (input[0] == -1)
            {
                Console.WriteLine("Incorrect input.");
                result = true; 
            }
            else result = false;
            return result;
        }

        public string ToPieceUnicoded(PiecesChar piecechar)
        {
            string result = "no name"; // default value
            foreach (Piece piece in panel.GetpiecesLeft())
            {
                if (piecechar == piece.GetChars())
                {
                    result = piece.GetUnicoded();
                    break; // Break the loop once the piece is found
                }
            }
            return result;
        }
    } 
}