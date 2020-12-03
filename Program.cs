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
            while (playerPosition != 100)
            {
                int playerDice = rollDice();
                int option = checkOption();
                int winPosition = 100;
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
                        playerPosition -= playerDice;
                        break;
                    default:
                        Console.WriteLine("Player not playing.");
                        break;
                }
            }
        }
    }
}
