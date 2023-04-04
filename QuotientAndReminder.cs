using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class QuotientAndReminder
    {
        public static void findQuotientAndReminder()
        {
            Console.WriteLine("please enter a number to divide");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quotient is : " + dividend / divisor);
            Console.WriteLine("reminder is:"+dividend % divisor);
        }
    }
}
