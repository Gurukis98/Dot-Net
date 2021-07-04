using System;

namespace Snake_and_Ladder_UC_4
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Random random = new Random();
            int Die = random.Next(1, 101);
            for (int i=1;i<2;i++)
            {
                if (Die == 100)
                {
                    break;
                }
                Console.WriteLine("Player Reaches: " + Die);
            }

        }
    }
}
