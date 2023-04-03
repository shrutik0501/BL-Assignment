using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class LeapYear
    {
        public static void findLeapYear()
        {
            Console.WriteLine("enter Year no");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {

                Console.WriteLine("leap year");

            }
            else
            if (year % 100 == 0)
            {

                Console.WriteLine("not a leap year");

            }
            else
            if (year % 4 == 0)
                Console.WriteLine("leap year");

        }
    }
}

