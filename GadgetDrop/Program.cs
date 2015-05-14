using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            double floors = 30;
            double test = Math.Sqrt(floors);
            test = Math.Ceiling(test);
            bool gadget1 = true; // true means not broken, false means broken
            bool gadget2 = true;
            int k = 0;
            int a = 1;

            for (int i = 1; i <= floors; i++)
            {
                test *= i;
                k=i;

                if (gadget1.ExplodesOnGroundBelow)
                {
                    gadget1 = false;
                }
                }

            if(gadget1 == true) {
                Console.Write("We can reach the highest floor in the building.");
            }
            else {
                while (gadget2 == true)
                {
                    test *= (k - a);
                    a++;
                }

                test -= 1; // We hit the highest spot with gadget #2, so back down 1 and that's our highest floor.
                test = Math.Pow(test, 2); // To remove sqrt.

            }
            Console.Write("We can reach floor {0}", test);
            



        }
    }
}
