using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {  
            ShowInfo.ShowIntro();
            Game game = new Game();
            
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
                Console.WriteLine("You win.");
            }
            else if (game.CheckForWinner("X"))
            {
                Console.WriteLine("You lost.");
            }
            else if (game.CheckIfFull())
            {
                Console.WriteLine("It is a tie.");
            }
        }
    }
}
