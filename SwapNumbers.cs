using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class SwapNumbers
    {
        public static void swapping()
        {
            Console.WriteLine("enter first number to swap");
            int firstNumber= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number to swap");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int swap = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swap;
            Console.WriteLine("first number after swapping is : " + firstNumber);
            Console.WriteLine("second number after swapping is : " + secondNumber);

        }
    }
}
