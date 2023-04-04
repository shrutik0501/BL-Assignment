using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flip_coin
{
    internal class Alphabets
    {
        public static void checkAlphabets()
        {
            Console.WriteLine("please enter a character to check vowel or consonant");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'A'||input == 'E' || input == 'I' || input == 'O' || input == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
                Console.WriteLine("consonant");


        }
    }
}

    

