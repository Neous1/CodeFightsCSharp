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
            var s = "abacabad";
            Console.WriteLine("Non repeating chararacter is: ", FirstNotRepeatingChar(s));
        }
        
        public static char FirstNotRepeatingChar(string s)
        {
            var myList = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (!myList.ContainsKey(item))
                    myList[item] = 1;
                else
                    myList[item]++;
            }

            foreach (var i in myList)
            {
                if (i.Value == 1)
                    return i.Key;
            }
            return '_';
        }
    }
}
