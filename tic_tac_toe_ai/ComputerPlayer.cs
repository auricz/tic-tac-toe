using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
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

        private static bool IsThereAlmostWinner(string[] allSpots, string playerLetter, out int winningSpotIndex)       // True if one spot away from winning, and outs that index
        {
            winningSpotIndex = 0;

            string[] topRow = { allSpots[6], allSpots[7], allSpots[8] };
            string[] midRow = { allSpots[3], allSpots[4], allSpots[5] };
            string[] bottomRow = { allSpots[0], allSpots[1], allSpots[2] };
            string[] leftColumn = { allSpots[0], allSpots[3], allSpots[6] };
            string[] midColumn = { allSpots[1], allSpots[4], allSpots[7] };
            string[] rightColumn = { allSpots[2], allSpots[5], allSpots[8] };
            string[] topLeftToBottomRight = { allSpots[2], allSpots[4], allSpots[6] };
            string[] topRightToBottomLeft = { allSpots[0], allSpots[4], allSpots[8] };

            if (IsThereTwoSameLettersAndOpenSpace(topRow, playerLetter))
            {
                winningSpotIndex = Array.IndexOf(topRow, " ") + 6;      // EX: index 0 (top left in top row) plus 6 for index 6 (top left in all spots)
                return true;                                            // index 0 = new index 6, 1 = 7, 2 = 8
            }
            else if (IsThereTwoSameLettersAndOpenSpace(midRow, playerLetter))
            {
                winningSpotIndex = Array.IndexOf(midRow, " ") + 3;      // EX: index 0 (mid left in mid row) plus 3 for index 3 (mid left in all spots)
                return true;                                            // 0 = 3, 1 = 4, 2 = 5
            }
            else if (IsThereTwoSameLettersAndOpenSpace(bottomRow, playerLetter))
            {
                winningSpotIndex = Array.IndexOf(bottomRow, " ");       // EX: index 0 (bottom left in bottom row) is index 0 (bottom left in all spots)
                return true;                                            // 0 = 0, 1 = 1, 2 = 2
            }
            else if (IsThereTwoSameLettersAndOpenSpace(leftColumn, playerLetter))
            {
                winningSpotIndex = Array.IndexOf(leftColumn, " ") * 3;          // EX: index 1 (mid left in left column) times 3 for index 3 (mid left in all spots)
                return true;                                                    // 0 = 0, 1 = 3, 2 = 6
            }
            else if (IsThereTwoSameLettersAndOpenSpace(midColumn, playerLetter))
            {
                winningSpotIndex = (Array.IndexOf(midColumn, " ") * 3) + 1;     // EX: index 1 (mid mid in mid column) times 3 plus 1 for index 4 (mid mid in all spots)
                return true;                                                    // 0 = 1, 1 = 4, 2 = 7
            }
            else if (IsThereTwoSameLettersAndOpenSpace(rightColumn, playerLetter))
            {
                winningSpotIndex = (Array.IndexOf(rightColumn, " ") * 3) + 2;   // EX: index 1 (mid right in right column) times 3 plus 2 for index 5 (mid right in all spots)
                return true;                                                    // 0 = 2, 1 = 5, 2 = 8
            }
            else if (IsThereTwoSameLettersAndOpenSpace(topLeftToBottomRight, playerLetter))
            {
                winningSpotIndex = (Array.IndexOf(topLeftToBottomRight, " ") * 2) + 2;      // EX: index 1 (mid mid in diagonal) times 2 plus 2 for index 4 (mid mid in all spots)
                return true;                                                                // 0 = 2, 1 = 4, 2 = 6
            }
            else if (IsThereTwoSameLettersAndOpenSpace(topRightToBottomLeft, playerLetter))
            {
                winningSpotIndex = Array.IndexOf(topRightToBottomLeft, " ") * 4;            // EX: index 1 (mid mid in diagonal) times 4 for index 4 (mid mid in all spots)
                return true;                                                                // 0 = 0, 1 = 4, 2 = 8
            }
            else
            {
                return false;
            }
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
