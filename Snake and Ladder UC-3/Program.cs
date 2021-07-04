using System;

namespace Snake_and_Ladder_UC_3
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int No_Play = 0;
            int Play = 1;
            Random random = new Random();
            int playerCheck = random.Next(0, 2);
            if (playerCheck == No_Play)
            {
                Console.WriteLine("No Play");
            }
            else if (playerCheck == Play)
            {
                Console.WriteLine("Ladder");
            }
            else
            {
                Console.WriteLine("Snake");
            }    
        }
    }
}
