using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace RockPaperScissorsGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            int wins = 0;
            int losses = 0;
            int draws = 0;

            string playAgain = "";

            do
            {

                ConsoleColor foregroundPlayer = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();
                Console.ResetColor();



                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "Scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    ConsoleColor foregroundIvalid = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Invalid Input. Try Again...");
                    Console.ResetColor();
                    return;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = "Rock";
                        break;
                    case 2:
                        computerMove = "Paper";
                        break;
                    case 3:
                        computerMove = "Scissors";
                        break;
                    default:
                        break;
                }

                ConsoleColor foregroundComputer = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"The computer chose: {computerMove}.");
                Console.ResetColor();

                if ((playerMove == "Rock" && computerMove == "Scissors") ||
                    (playerMove == "Paper" && computerMove == "Rock") ||
                    (playerMove == "Scissors" && computerMove == "Paper"))
                {
                    ConsoleColor foregroundWin = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You win.");
                    Console.ResetColor();
                    wins++;
                }
                else if ((playerMove == "Rock" && computerMove == "Paper") ||
                    (playerMove == "Paper" && computerMove == "Scissors") ||
                    (playerMove == "Scissors" && computerMove == "Rock"))

                {
                    ConsoleColor foregroundLose = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You lose.");
                    Console.ResetColor();
                    losses++;
                }
                else
                {
                    ConsoleColor foregroundDraw = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"This game was a draw");
                    Console.ResetColor();
                    draws++;
                }

                Console.WriteLine($"Type [yes] to Play Again or [no] to quit: ");
                playAgain = Console.ReadLine();

            } while (playAgain == "yes");
            
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine($"Final score: Wins:{wins} Losses:{losses} Draws:{draws}");
            

            
        }
    }
}
