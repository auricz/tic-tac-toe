using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    static class ComputerPlayer
    {
        public static int ChooseSpot(string[] takenAnswers)
        {
            int chosenAnswer = 0;
            bool validSpot = false;
            Random rand = new Random();

            while (validSpot == false)
            {
                chosenAnswer = rand.Next(0, 9);
                if (takenAnswers[chosenAnswer] == " ")
                {
                    validSpot = true;
                }
            }

            return chosenAnswer;
        }

        private static bool IsThereTwoSameLettersAndOpenSpace(string[] threeInRow, string letter)
        {
            int count = 0;
            bool isThereOpenSpace = false;

            foreach (string letterInSpot in threeInRow)
            {
                if (letterInSpot == letter)
                {
                    count++;
                }
                else if (letterInSpot == " ")
                {
                    isThereOpenSpace = true;
                }
            }

            if (count == 2 && isThereOpenSpace == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
