using System;

namespace Snake_and_Ladder_UC_6
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[16];  
            arr[1] = 5;  
            arr[2] = 15;
            arr[3] = 26;
            arr[4] = 35;
            arr[5] = 29;
            arr[6] = 34;
            arr[7] = 56;
            arr[8] = 64;
            arr[9] = 60; 
            arr[10] = 72;
            arr[11] = 65;
            arr[12] = 78;
            arr[13] = 84;
            arr[14] = 94;
            arr[15] = 100;
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine("Current Position is: " + arr[i]);
            }
        }
    }
}
