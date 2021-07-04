using System;

namespace Snake_and_Ladder_UC_5
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int i = 100;
            Random random = new Random();
            int exactCheck = random.Next(99, 101);
            if (exactCheck == 100)
            {
                Console.WriteLine("Exact Position: " + i);
            }
            else
            {
                Console.WriteLine("Not Exact Position:");
            }
        }    
    }
}
