using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int humanWins = 0;
            int computerWins = 0;
            int ties = 0;
            bool isGameDone = false;
            
            ShowInfo.ShowIntro();

            while (isGameDone == false)
            {
                string continueOrNot;
                bool isValidInput = false;

                Game game = new Game();

                if (Game._gameCount % 2 == 0)       // Lets computer go first after every other game
                {
                    game.ComputerTurn();
                    ShowInfo.ShowBoard(game.CurrentAnswers);
                }
                
                while (game.CheckIfFull() == false)
                {
                    game.HumanTurn();
                    ShowInfo.ShowBoard(game.CurrentAnswers);
                    if (game.CheckForWinner("O") || game.CheckIfFull())
                    {
                        break;
                    }

                    game.ComputerTurn();
                    ShowInfo.ShowBoard(game.CurrentAnswers);
                    if (game.CheckForWinner("X") || game.CheckIfFull())
                    {
                        break;
                    }
                }

                if (game.CheckForWinner("O"))
                {
                    Console.WriteLine("\nYou won.\n");
                    humanWins++;
                }
                else if (game.CheckForWinner("X"))
                {
                    Console.WriteLine("\nYou lost.\n");
                    computerWins++;
                }
                else if (game.CheckIfFull())
                {
                    Console.WriteLine("\nIt is a tie.\n");
                    ties++;
                }

                Console.WriteLine($"Games won: {humanWins}");
                Console.WriteLine($"Games lost: {computerWins}");
                Console.WriteLine($"Games tied: {ties}");
                Console.Write("\nPlay again? y/n: ");

                while (isValidInput == false)
                {
                    continueOrNot = Console.ReadLine().ToLower();
                    if (continueOrNot == "y")
                    {
                        isValidInput = true;
                    }
                    else if (continueOrNot == "n")
                    {
                        isValidInput = true;
                        isGameDone = true;
                    }
                    else
                    {
                        Console.Write("\nYou must enter 'y' (yes) or 'n' (no): ");
                    }
                }
            }
        }
    }
}
