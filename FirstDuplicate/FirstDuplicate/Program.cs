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


            int holder;
            int [] a = { 2,3,3,1,5,2};
            
            var myDict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                myDict.Add(i, a[i]);
                //Console.WriteLine("HI");
            }

            foreach (var item in myDict)
            {
                holder = item.Value;
               // Console.WriteLine(item);
                if (myDict.ContainsValue(holder))
                {
                    Console.WriteLine(holder);
                    //Console.WriteLine("{0} {1}", item.Key, item.Value);
                   
                }
                
            }

            Console.ReadLine();

        }
    }
}
