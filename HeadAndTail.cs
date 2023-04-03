using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class HeadAndTail
    {

        public static void findHeadAndTail(int flipTimes)
        {
            Random random = new Random();
            int head=0, tail=0;
            for (int i = 0; i < flipTimes; i++)
            {
                int result=random.Next(0,2);
                if (result == 0)
                {
                    tail++;

                }
                else
                {
                    head++;
                }
            }
            double headPercentage = head * 100 / flipTimes;
            Console.WriteLine("the head percentage is : "+headPercentage +"%");
            Console.WriteLine("the tail percentage is : " +(100- headPercentage) + "%");
        }
    
    }
}
