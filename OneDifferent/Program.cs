using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDifferent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[9] { 5, 5, 5, 5, 5, 5, 9, 5, 5 };
            int real = 0;
            int fake = 0;

            if (coins[0] == coins[1])
            {
                real = coins[0];
                
            }
            else if (coins[0] == coins[2])
            {
                real = coins[0];
                
            }
            else
            {
                real = coins[1];
                
            }

                foreach(int item in coins) {
                    if (item != real) {
                        fake = item;
                        // return fake;
                    }
            }
                Console.Write(fake);
        }
    }
}
