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
            


            int [] a = { 2,3,3,1,5,2};


            /*
            iterate array
            print a[0]
            set a[a[0]] to -a[a[0]]
            */

//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[Math.Abs(a[i])] > 0 )
//                {
//                    a[Math.Abs(a[i])] = -a[Math.Abs(a[i])];
//                    Console.WriteLine(a[Math.Abs(a[i])]);
//                    Console.WriteLine(a[Math.Abs(a[i])]);
                   
//                    }
//                break;
////                //find first dup
////
////                else
////                Console.WriteLine -1;
/// 
///        
            
            var myDict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                myDict.Add(i, a[i]);
                //Console.WriteLine("HI");
            }

            foreach (var item in myDict)
            {
                if (myDict.Values)
                {
                    
                }
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
