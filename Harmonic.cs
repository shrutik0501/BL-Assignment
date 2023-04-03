using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class Harmonic
    {
        public static void findHarmonic()
        {
            Console.WriteLine("enter terms");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            float sum = 0;
            for (int j = 0; j <= n; j++)
            {
                sum = sum + (float)1 / i;
                i++;
            }
            Console.WriteLine("sum=" + sum);
        }
    }
}
