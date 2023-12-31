using System;


namespace RockPaperScissorsGame
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissor";

            start:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if(playerMove == "rock"|| playerMove == "r"|| playerMove == "Rock")
            {
                playerMove = Rock;
            }
            else if(playerMove == "paper"||playerMove == "p"||playerMove == "Paper")
            {
                playerMove = Paper;
            }
            else if(playerMove =="scissors"||playerMove == "s"||playerMove == "Scissors")
            {
                playerMove = Scissors;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Invalid Input. Try Again...");
                return;
                    
            }
            Random random = new Random();
            byte computerRandomNumber = (byte)random.Next(1, 4);
            string computerMove = string.Empty;

            switch(computerRandomNumber)
            {
               case 1: computerMove = Rock; 
                    break;
               case 2: computerMove = Paper; 
                    break;
               case 3: computerMove = Scissors; 
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"The computer chose {computerMove}.");

            if(playerMove == Rock && computerMove == Scissors
                ||playerMove==Paper && computerMove==Rock
                ||playerMove == Scissors && computerMove == Paper) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
            }
            else if(computerMove == Rock && playerMove == Scissors
                || computerMove == Paper && playerMove == Rock
                || computerMove == Scissors && playerMove == Paper)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw");
            }

        start2:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you want to play more? Type 'y' for Yes and 'n' for No.");
            char input = char.Parse(Console.ReadLine());
            if (input == 'y')
            {
                goto start;
            }
            else if(input == 'n')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Thank you for playing!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Invalid input. Please enter 'y' or 'n'.");
                goto start2;
            }

        }
    }
}
