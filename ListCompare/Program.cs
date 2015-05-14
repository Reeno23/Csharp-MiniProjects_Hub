using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 5, 5 };
            int[] b = { 2, 2, 3, 5, 5, 7 };
            List<int> listOfSame = new List<int>();
            Boolean toggle = false;


            for(int i = 0; i<a.Length; i++)
            {
                toggle = false;
                 for(int j = 0; j<b.Length; j++)
            {
                     if (a[i] == b[j] && toggle == false) {
                         listOfSame.Add(a[i]);
                         toggle = true;

                     }
            }

            }
            Console.WriteLine("Numbers that were the same in each list were: ");

            foreach (int same in listOfSame)
            {
                Console.WriteLine(same);
            }
            
        }
    }
}
