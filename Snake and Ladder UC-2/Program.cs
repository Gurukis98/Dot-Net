using System;

namespace ConsoleApp1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int Die;
            Random random = new Random();

            Die = random.Next(1, 7);
            Console.WriteLine("Your value is: " + Die);
        }
    }
}
