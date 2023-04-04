using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class EvenOdd
    {
        public static void checkEvenOdd()
        {
            Console.WriteLine("please enter a number to check even or odd");
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number%2==0) 
            {
                Console.WriteLine("even number");
            }
            else
                Console.WriteLine("odd number");


        }
    }
}
