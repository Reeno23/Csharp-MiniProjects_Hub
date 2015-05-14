using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "It is me Mario";
            RevString(a);
            

        }

        public static string RevString(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return RevString(str.Substring(1)) + str[0];
        }
    }
}




