using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder***");
            int playerPosition = 0;
            int playerDice = rollDice();
        }
        public static int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1,7);
            return dice;
        }
    }
}
