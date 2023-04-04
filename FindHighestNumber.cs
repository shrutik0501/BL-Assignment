using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class FindHighestNumber
    {
        public static void findMaximum(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("highest number is : " + a);

            }
          else  if (b>c && b>a)
            {
                Console.WriteLine("highest number is : " + b);

            }
            else
            {
                Console.WriteLine("highest number is : " + c);

            }
        }
    }

}
