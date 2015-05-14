using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            String one = "Piccolo";
            String two = "olocciP";

            String anagram = checkAnagram(one, two);
            Console.WriteLine(anagram);
        }

      public static string checkAnagram(String a, String b) {

          String output = "";
          String result = "";
          int length = b.Length;

        for(int i=0; i<a.Length; i++)
        {
            if(a[i].Equals(b[length-i-1]))
            {
                output += b.Substring(length-i-1, 1);
            }
        }

        if (output.Equals(a))
        {

            result = ("Nice, " + a + " and " + b + " are anagrams.");

        }
        else
        {
            result = "Better luck next time.";
        }
        
        return result;
    }

        
    }
}
