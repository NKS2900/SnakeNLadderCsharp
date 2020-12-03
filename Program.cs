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
            int playerPosition = 0;
            int winPosition = 100;
            int countRound = 0;
            while (playerPosition != 100)
            {
                int playerDice = rollDice();
                int option = checkOption();
                countRound++;              
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player Got Ladder.");
                        playerPosition += playerDice;
                        if (playerPosition > winPosition)
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got Snake.");
                        if ((playerPosition - playerDice) < 0)
                        {
                            playerPosition = 0;
                        }
                        else
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Player not playing.");
                        break;
                }
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :Player_Position: {playerPosition}");
                if (playerPosition == winPosition)
                {
                    Console.WriteLine("Player Won The SnkeNLadder***");
                    Console.WriteLine("Roll_Dice_Count: " + countRound);
                    break;
                }
            }
        }
    }
}
