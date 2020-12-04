using System;

namespace SnakeAndLadder
{
    class Program
    {
        public static int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        public static int checkOption()
        {
            Random random = new Random();
            int option = random.Next(1,4);
            return option;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder***");
            int playerOnePosition = 0, playerTwoPosition = 0, winPosition = 100, countRound = 0;

            while (playerOnePosition != 100 && playerTwoPosition != 100)
            {
                int playerOneDice = rollDice();
                int playerTwoDice = rollDice();
                int option = checkOption();
                countRound++;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player Got Ladder.");
                        playerOnePosition += playerOneDice;
                        playerTwoPosition += playerTwoDice;
                        int OneChance = rollDice();
                        playerOnePosition += playerOneDice;//If got ladder Rolling again
                        int TwoChance = rollDice();
                        playerTwoPosition += playerTwoDice;//If got ladder Rolling again
                        if (playerOnePosition > winPosition)
                        {
                            playerOnePosition -= playerOneDice;                          
                        }
                        else if (playerTwoPosition > winPosition)
                        {
                            playerTwoPosition -= playerTwoDice;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got Snake.");
                        if ((playerOnePosition - playerOneDice) < 0)
                        {
                            playerOnePosition = 0;

                        }
                        else if ((playerTwoPosition - playerTwoDice) < 0)
                        {
                            playerTwoPosition = 0;
                        }
                        else
                        {
                            playerOnePosition -= playerOneDice;
                            playerTwoPosition -= playerTwoDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Player not playing.");
                        break;
                }
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :Player_One_Position: {playerOnePosition}");
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :Player_Two_Position: {playerTwoPosition}");
                if (playerOnePosition == winPosition || playerTwoPosition == winPosition)
                {
                    if (playerOnePosition == winPosition)
                    {

                        Console.WriteLine("----------Player_One_Won----------");
                        Console.WriteLine("Number of times dice was played : {0}", countRound);                        
                    }
                    else if (playerTwoPosition == winPosition)
                    {

                        Console.WriteLine("----------Player_Two_Won----------");
                        Console.WriteLine("Number of times dice was played : {0}", countRound);                       
                    }
                }
            }
        }
    }
}
