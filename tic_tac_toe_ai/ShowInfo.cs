using System;

namespace tic_tac_toe
{
    static class ShowInfo
    {
        public static void ShowIntro()      // Called at beginning of program to show intructions only
        {
            Console.WriteLine("==================================");
            Console.WriteLine("   Tic-Tac-Toe Against Computer   ");
            Console.WriteLine("==================================");
            Console.WriteLine("Try to get a 3-in-a-row and win the game before the computer can get a 3-in-a-row.");
            Console.WriteLine("When it is your turn enter the number corresponding to your desired spot.");
            Console.WriteLine("You are playing as O. The computer is X.");
            Console.WriteLine("");
            Console.WriteLine("           7 | 8 | 9 ");
            Console.WriteLine("          ---|---|---");
            Console.WriteLine("           4 | 5 | 6 ");
            Console.WriteLine("          ---|---|---");
            Console.WriteLine("           1 | 2 | 3 ");
        }

        public static void ShowBoard(string[] answers)      // Called after each move to show updated board with X and O
        {
            Console.WriteLine($"\n           {answers[6]} | {answers[7]} | {answers[8]} ");
            Console.WriteLine("          ---|---|---");
            Console.WriteLine($"           {answers[3]} | {answers[4]} | {answers[5]} ");
            Console.WriteLine("          ---|---|---");
            Console.WriteLine($"           {answers[0]} | {answers[1]} | {answers[2]} ");
        }
    }
}
