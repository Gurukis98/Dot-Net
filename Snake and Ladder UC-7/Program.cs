using System;

namespace Snake_and_Ladder_UC_7
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int Player1 = 0;
            int Player2 = 1;
            Random random = new Random();
            int playerCheck = random.Next(0, 2);
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Player1 at Position: " + 100);
            }
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Player2 at Position: " + 85);
            }
            if (playerCheck == Player1)
            {
                Console.WriteLine("Player1 is Win");
            }
            else if (playerCheck == Player2)
            {
                Console.WriteLine("Player2 is Loss");
            }
         
        }
    }
}
