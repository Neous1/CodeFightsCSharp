using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {

          int [] a = { 2,2,3,3,1,5,2};
            Console.WriteLine(thefirstDuplicate(a)+"\n");
            

            //Console.ReadLine();

        }

        public static int thefirstDuplicate(int[] a)
        {
            var myDict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (myDict.ContainsKey(a[i]))
                    return a[i];
                else
                {
                    myDict.Add(a[i], 1);
                }
            }
            return -1;
        }
    }
}
