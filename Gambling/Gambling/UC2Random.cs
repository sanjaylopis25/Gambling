using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling
{
    public class UC2Random
    {
        const int WON = 1;
        const int LOST = 0;
        public static void WinOrLose()
        {
            int stake = 100;
            const int BET_PER_DAY = 1;
            Random random = new Random();
            int choice = random.Next(0, 2);
            if (choice == WON)
            {
                stake = stake + BET_PER_DAY;
                Console.WriteLine("Won");
                Console.WriteLine("You Have :"+stake);
            }
            else if (choice == LOST)
            {
                stake = stake - BET_PER_DAY;
                Console.WriteLine("Lost");
                Console.WriteLine("You Have :" + stake);
            }
        }
    }
}
