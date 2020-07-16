using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace tic_tac_toe
{
    class Game
    {
        public string[] CurrentAnswers
        { get; private set; }

        public Game()
        {
            CurrentAnswers = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
        }
        
        public void HumanTurn()
        {
            int indexOfHumanSpot = HumanPlayer.ChooseSpot(CurrentAnswers);
            CurrentAnswers[indexOfHumanSpot] = "O";
        }

        public void ComputerTurn()
        {
            int indexOfComputerSpot = ComputerPlayer.ChooseSpot(CurrentAnswers);
            CurrentAnswers[indexOfComputerSpot] = "X";
        }

        public bool CheckForWinner(string playerLetter)     // Returns true if someone won (if O is passed then it checks if person won)
        {
            if (playerLetter == "O" || playerLetter == "X")
            {
                if (CurrentAnswers[6] == playerLetter && CurrentAnswers[7] == playerLetter && CurrentAnswers[8] == playerLetter)        // Top row
                {
                    return true;
                }
                else if (CurrentAnswers[3] == playerLetter && CurrentAnswers[4] == playerLetter && CurrentAnswers[5] == playerLetter)   // Mid row
                {
                    return true;
                }
                else if (CurrentAnswers[0] == playerLetter && CurrentAnswers[1] == playerLetter && CurrentAnswers[2] == playerLetter)   // Bottom row
                {
                    return true;
                }
                else if (CurrentAnswers[6] == playerLetter && CurrentAnswers[3] == playerLetter && CurrentAnswers[0] == playerLetter)   // Left column
                {
                    return true;
                }
                else if (CurrentAnswers[7] == playerLetter && CurrentAnswers[4] == playerLetter && CurrentAnswers[1] == playerLetter)   // Mid column
                {
                    return true;
                }
                else if (CurrentAnswers[8] == playerLetter && CurrentAnswers[5] == playerLetter && CurrentAnswers[2] == playerLetter)   // Right column
                {
                    return true;
                }
                else if (CurrentAnswers[6] == playerLetter && CurrentAnswers[4] == playerLetter && CurrentAnswers[2] == playerLetter)   // Top-left to bottom-right
                {
                    return true;
                }
                else if (CurrentAnswers[8] == playerLetter && CurrentAnswers[4] == playerLetter && CurrentAnswers[0] == playerLetter)   // Top-right to bottom-left
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("This is checking for something not an O or X.");
                return false;
            }
        }

        public bool CheckIfFull()       // Returns true if entire board is fulled and likely a tie
        {
            foreach (string spot in CurrentAnswers)
            {
                if (String.IsNullOrWhiteSpace(spot))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
