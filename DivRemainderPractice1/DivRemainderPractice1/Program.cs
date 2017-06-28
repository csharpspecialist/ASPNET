using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DivRemainderPractice1
{
    class Program
    {
        public static void Main()
        {
            int var1 = 167;
            int var2 = 12;

            int quotient, remainder;

            quotient = var1 / var2;

            remainder = var1 % var2;

            WriteLine($"the quotient is {quotient} & the remainder is {remainder}");
            ReadLine();
        }
    }
}
