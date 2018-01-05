using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNoRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abacabad";
        }
        
        public static char firstNotRepeatingChar(string s)
        {
            var myList = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (!myList.ContainsKey(item))
                    myList[item] = 1;
                else
                    myList[item]++;
            }
        }
    }
}
