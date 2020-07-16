using System;
using System.Collections.Generic;
using System.Text;

namespace tic_tac_toe
{
    static class HumanPlayer
    {
        public static int ChooseSpot(string[] takenAnswers)        // Returns the index of the spot the user chose (user enters 4, returns 3 because index)
        {
            int playerSpot = 0;
            bool validSpot = false;
            
            while(validSpot == false)
            {
                Console.Write("It is your turn. Enter your spot number: ");
                
                try 
                {
                    playerSpot = Int32.Parse(Console.ReadLine());
                    if (takenAnswers[playerSpot - 1] == " ")
                    {
                        validSpot = true;
                    }
                    else
                    {
                        Console.WriteLine("\nYou must choose a spot not taken yet.\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nYou must enter a number without letters or symbols.\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nYou must enter a number between 1 and 9.\n");
                }
                
            }

            return playerSpot - 1;
        }
    }
}
